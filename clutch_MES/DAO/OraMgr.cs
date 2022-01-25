using clutch_MES.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clutch_MES.DAO
{
    class OraMgr
    {
        const string ORADB = "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));" +
            "User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        static OraMgr instance;

        public static OraMgr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OraMgr();
                }
                return instance;
            }
        }

        // 생성자
        public OraMgr()
        {
            Console.WriteLine("오라클 객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
        }

        // 소멸자
        ~OraMgr()
        {
            closeDB();
            Console.WriteLine("오라클 객체 소멸");
        }

        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 오류: " + e.Message);
                Environment.Exit(0);
            }
        }
        public void closeDB()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 접속 해제");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 해제 오류: " + e.Message);
            }
        }

        public void createTable()
        {
            try
            {
                string sql = "create table student_t (" +
                    "id number not null," +
                    "name varchar(20) not null," +
                    "age number not null," +
                    "addr varchar(80) not null," +
                    "constraint pk_student_id primary key(id))";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "create sequence seq_id " +
                    "increment by 1 start with 1000";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 생성 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 생성 오류: " + e.Message);
            }
        }

        public void dropTable()
        {
            try
            {
                string sql = "drop table student_t";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                string seq = "drop sequence seq_id";
                cmd.CommandText = seq;
                cmd.ExecuteNonQuery();
                Console.WriteLine("테이블, 시퀀스 삭제 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블(시퀀스) 삭제 오류: "
                    + e.Message);
            }
        }

        public void insertDB()
        {
            try
            {
                string name = "홍길동";
                int age = 200;
                string addr = "조선 한양 홍대감댁 11번지";
                string sql = string.Format("insert into student_t values (" +
                    "seq_id.nextval, '{0}', {1}, '{2}')",
                    name, age, addr);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public List<Stock> getAllStock()
        {
            List<Stock> list = new List<Stock>();
            try
            {
                string sql = string.Format("Select itemcode, stockquantity from stock_t"
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader rb = cmd.ExecuteReader();

                if (rb.HasRows)
                {
                    while (rb.Read())
                    {
                        Stock stock = new Stock(
                            rb["itemcode"].ToString(),
                            int.Parse(rb["stockquantity"].ToString()));

                        list.Add(stock);
                    }
                }
            }
            catch 
            {
                Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
            }
            return list;
        }

        public void insertDB(Purchase purchase)
        {
            try
            {
                string sql = string.Format("insert into PURCHASE_T values (" +
                    "PURCHASE_T_seq.nextval, {0},{1}, '{2}','{3}',{4},'{5}','{6}',{7},'{8}')",
                    purchase.CompanyNum, purchase.Supplier, purchase.Status, purchase.ItemCode, 
                    purchase.Quantity, purchase.PurchaseAddDate, purchase.PurchaseInDate,
                    purchase.Purchaser, purchase.Note
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("데이터 추가 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertDB(Supplier supplier)
        {
            try
            {
                string sql = string.Format("insert into Supplier_T values (" +
                    "{0}, '{1}', '{2}', '{3}', '{4}')",
                    supplier.SupplierNum, supplier.SupplierName, supplier.SellingItem,
                    supplier.CeoName, supplier.Adress
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("데이터 추가 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void insertDB(BOM bom)
        {
            try
            {
                string sql = string.Format("insert into BOM_T values ('{0}','{1}',{2})",
                    bom.PNum, bom.CNum,bom.Quantity
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("BOM 데이터 추가 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertInStockHistoryDB(StockHistory stockhistory)
        {
            try
            {
                string sql = string.Format("insert into stockhistory_T " +
                    "(Section, PurchaseNum, CompanyNum, ItemCode, StockQuantity, " +
                    "InDate, Warehouse, Note) " +
                    "values ('{0}',{1}, {2},'{3}',{4},'{5}','{6}','{7}')",
                    stockhistory.Section, stockhistory.PurchaseNum,
                    stockhistory.CompanyNum, stockhistory.ItemCode,
                    stockhistory.StockQuantity, stockhistory.InDate,
                    stockhistory.Warehouse, stockhistory.Note
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("데이터 추가 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertOutStockHistoryDB(StockHistory stockhistory)
        {
            try
            {
                string sql = string.Format("insert into stockhistory_T " +
                    "(Section, workOrderNum, CompanyNum, ItemCode, StockQuantity, " +
                    "InDate, Note) " +
                    "values ('{0}',{1}, {2},'{3}',{4},'{5}','{6}')",
                    stockhistory.Section, stockhistory.WorkOrderNum,
                    stockhistory.CompanyNum, stockhistory.ItemCode,
                    stockhistory.StockQuantity, stockhistory.InDate,
                    stockhistory.Note
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
               
            }
            catch (OracleException e)
            {
                MessageBox.Show("데이터 추가 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void insertDB(Work work)
        {
            try
            {
                string sql = string.Format("insert into WORKORDER_T values (" +
                    "WORKORDER_T_seq.nextval, {0},'{1}', {2},'{3}',{4},'{5}'" +
                    ",'{6}')", work.CompanyNum, work.MachineLine, work.WorkerID,
                    work.ItemCode, work.WorkQuantity, work.WorkDate, work.WorkNote
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void insertDB(Worked worked)
        {
            try
            {
                string sql = string.Format("insert into WORKED_T values (" +
                    "{0}, WORKED_T_seq.nextval, '{1}', {2},'{3}','{4}')",
                    worked.WorkOrderNum, worked.WorkedDate,
                    worked.DefectQuantity, worked.DefectCode,
                    worked.Workedquantity
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }
        public void insertDB(Machine machine)
        {
            try
            {
                string sql = string.Format("insert into MACHINE_T values (" +
                    "'{0}','{1}')", machine.MachineLine, machine.MachineName
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // 사원 기준정보 저장
        public void insertDB(Worker worker)
        {
            try
            {
                string sql = string.Format("insert into WORKER_T values (" +
                    "{0},'{1}','{2}','{3}')", worker.WorkerID, worker.WorkerName,
                    worker.InCompany, worker.Etc
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // 품목 기준정보 저장
        public void insertDB(Items item)
        {
            try
            {
                string sql = string.Format("insert into ITEM_T values (" +
                    "'{0}','{1}')", item.ItemCode, item.ItemName
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }

            try
            {
                string sql = string.Format("insert into stock_T values (" +
                    "'{0}',0)", item.ItemCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // 품목 기준정보 저장
        public void insertDB(Defect defect)
        {
            try
            {
                string sql = string.Format("insert into DEFECT_T values (" +
                    "'{0}','{1}')", defect.DefectCode, defect.DefectName
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // 사업장 기준정보 저장
        public void insertDB(Company company)
        {
            try
            {
                string sql = string.Format("insert into COMPANY_T values (" +
                    "'{0}','{1}')", company.CompanyNum, company.CompanyName
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // 공지사항 저장
        public void insertDB(Notice notice)
        {
            try
            {
                string sql = string.Format("insert into NOTICE_T values (" +
                    "{0},'{1}','{2}','{3}')",
                    notice.ContensNum, notice.Contents,
                    notice.WriteName, notice.WriteDate
                    );
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        // 회사번호 기준정보 저장

        // 사번 기준정보 저장

        public void DeleteDB(string machineLine)
        {
            try
            {
                string sql = string.Format("Delete From machine_t " +
                    "where machineline = '{0}'", machineLine);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
        public void DeleteWorkerDB(int workerID)
        {
            try
            {
                string sql = string.Format("Delete From worker_t " +
                    "where workerid = {0}", workerID);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }


        public void DeleteCompanyDB(int companyNum)
        {
            try
            {
                string sql = string.Format("Delete From company_t " +
                    "where companyNum = {0}", companyNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
        public void DeleteBOMDB(string pNum, string cNum, int quantity)
        {
            try
            {
                string sql = string.Format("Delete From BOM_t " +
                    "where pNum = {0} and cNum = {1} and quantity {2}", 
                    pNum, cNum, quantity);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("BOM 데이터 삭제 오류: " + e.Message);
            }
        }
        public void DeleteSupplierDB(Supplier supplier)
        {
            try
            {
                string sql = string.Format("Delete From Supplier_t " +
                    "where supplierNum = {0}",
                    supplier.SupplierNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("거래처 데이터 삭제 오류: " + e.Message);
            }
        }
        
        public void DeleteItemDB(string itemCode)
        {
            try
            {
                string sql = string.Format("Delete From item_t " +
                    "where itemcode = '{0}'", itemCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
        public void DeleteDefectDB(string defectCode)
        {
            try
            {
                string sql = string.Format("Delete From defect_t " +
                    "where defectcode = '{0}'", defectCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
        }
        public void DeleteDB(int contentsNum)
        {
            try
            {
                string sql = string.Format("Delete From notice_t " +
                    "where contentsNum = {0}", contentsNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 오류: " + e.Message);
            }
        }

        public List<Machine> getMachineVo()
        {
            string sql = "select machineline as 설비라인, " +
                "machinename as 라인명 from machine_t order by machinename";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Machine> list = new List<Machine>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Machine machine = new Machine(
                        rd["설비라인"].ToString(),
                        rd["라인명"].ToString());
                    list.Add(machine);
                }
            }
            else
            {
                Console.WriteLine("설비관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public string getItemCodeName(string itemCode)
        {
            string sql = string.Format
                ("select itemcode, itemname from item_t where itemcode = '{0}'", itemCode);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            
            string itemCodeName = null;

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    itemCodeName = rd["itemname"].ToString();
                }
            }
            else
            {
                Console.WriteLine("품번이 존재하지 않습니다.");
            }
            rd.Close();
            return itemCodeName;
        }
        public List<Worker> getWorkerVo()
        {
            string sql = "select workerid as 사번, " +
                "workername as 사원명, incompany as 입사일," +
                "etc as 특이사항 from worker_t order by workerid";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Worker> list = new List<Worker>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Worker worker = new Worker(
                        int.Parse(rd["사번"].ToString()),
                        rd["사원명"].ToString(),
                        rd["입사일"].ToString(),
                        rd["특이사항"].ToString());
                    list.Add(worker);
                }
            }
            else
            {
                Console.WriteLine("설비관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Worker> getWorkerVo(string workerName)
        {
            string sql = string.Empty;
            if (workerName != "")
            {
                sql = string.Format("select workerID as 사번, " +
                "workerName as 사원명, incompany as 입사일, etc as 특이사항" +
                " from worker_t where workername = '{0}'", workerName);
            }
            else
            {
                sql = "select workerID as 사번, " +
                "workerName as 사원명, incompany as 입사일, etc as 특이사항" +
                " from worker_t";
            }
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Worker> list = new List<Worker>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Worker worker = new Worker(
                        int.Parse(rd["사번"].ToString()),
                        rd["사원명"].ToString(),
                        rd["입사일"].ToString(),
                        rd["특이사항"].ToString());
                    list.Add(worker);
                }
            }
            else
            {
                Console.WriteLine("사원관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Defect> getDefectVo()
        {
            string sql = "select defectCode as 불량코드," +
                "defectName as 불량유형명 " +
                "from defect_t order by defectCode";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Defect> list = new List<Defect>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Defect defect = new Defect(
                        rd["불량코드"].ToString(),
                        rd["불량유형명"].ToString());
                    list.Add(defect);
                }
            }
            else
            {
                Console.WriteLine("불량유형관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Purchase> getsearchPurchaseVo(string[,] searchPurchase, string[,] searchDate)
        {
            List<Purchase> list = new List<Purchase>();
            try
            {
                string select = string.Format("select purchasenum, status, quantity, note," +
                    "companynum, itemcode, supplier, workerid, purchase_add_date, purchase_in_date");
                string where = "where 1=1";
                for (int i = 0; i < searchPurchase.GetLength(0); i++)
                {
                    if (searchPurchase[i, 1] != "")
                    {
                        where += string.Format(" and " +
                            "{0} like '{1}'", searchPurchase[i, 0], searchPurchase[i, 1]);
                    }
                }
                for (int i = 0; i < searchDate.GetLength(0); i++)
                {
                    if (searchDate[i, 1] != "")
                    {
                        where += string.Format(" and " +
                            "{0} >= '{1}'", searchDate[i, 0], searchDate[i, 1]);
                    }
                    if (searchDate[i, 2] != "")
                    {
                        where += string.Format(" and " +
                            "{0} <= '{1}'", searchDate[i, 0], searchDate[i, 2]);
                    }
                }
                string from = " from purchase_t ";

                string sql = select + from + where;
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Purchase purchase = new Purchase(
                            int.Parse(rd["purchasenum"].ToString()),
                            int.Parse(rd["companynum"].ToString()),
                            int.Parse(rd["supplier"].ToString()),
                            rd["status"].ToString(),
                            rd["itemcode"].ToString(),
                            int.Parse(rd["quantity"].ToString()),
                            rd["purchase_add_date"].ToString(),
                            rd["purchase_in_date"].ToString(),
                            int.Parse(rd["workerid"].ToString()),
                            rd["note"].ToString()
                            );
                        list.Add(purchase);
                    }
                }
                else
                {
                    Console.WriteLine("불량유형관련 데이터가 존재하지 않습니다.");
                }
                rd.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
            return list;
        }

        public List<StockHistory> getsearchStockHistoryVo(string[,] searchPurchase, string[,] searchDate)
        {
            List<StockHistory> list = new List<StockHistory>();
            try
            {
                string select = string.Format("select section, purchasenum, workordernum," +
                    "companynum, itemcode, stockquantity, indate, warehouse, note");
                string where = " where 1=1";
                for (int i = 0; i < searchPurchase.GetLength(0); i++)
                {
                    if (searchPurchase[i, 1] != "")
                    {
                        where += string.Format(" and " +
                            "{0} like '{1}'", searchPurchase[i, 0], searchPurchase[i, 1]);
                    }
                }
                for (int i = 0; i < searchDate.GetLength(0); i++)
                {
                    if (searchDate[i, 1] != "")
                    {
                        where += string.Format(" and " +
                            "{0} >= '{1}'", searchDate[i, 0], searchDate[i, 1]);
                    }
                    if (searchDate[i, 2] != "")
                    {
                        where += string.Format(" and " +
                            "{0} <= '{1}'", searchDate[i, 0], searchDate[i, 2]);
                    }
                }
                string from = " from stockhistory_t ";

                string sql = select + from + where;
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        StockHistory stockhistory = new StockHistory(
                            rd["SECTION"].ToString(),
                            rd["PURCHASENUM"].ToString(),
                            rd["WORKORDERNUM"].ToString(),
                            rd["COMPANYNUM"].ToString(),
                            rd["ITEMCODE"].ToString(),
                            rd["STOCKQUANTITY"].ToString(),
                            rd["INDATE"].ToString(),
                            rd["WAREHOUSE"].ToString(),
                            rd["NOTE"].ToString()
                            );
                        list.Add(stockhistory);
                    }
                }
                else
                {
                    Console.WriteLine("재고관련 데이터가 존재하지 않습니다.");
                }
                rd.Close();
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 오류: " + e.Message);
            }
            return list;
        }

        public List<workJoinVo> getDefectJoinVo()
        {
            string select = "Select defect_t.defectname as 불량명," +
                "sum(worked_t.defectquantity) as 불량합계";
            string from = " from defect_t, worked_t ";
            string where = " where defect_t.defectcode = worked_t.defectcode and " +
                "worked_t.defectcode <> '0-000-000' ";
            string group = " group by defect_t.defectcode, defect_t.defectname";

            string sql = select + from + where + group;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<workJoinVo> list = new List<workJoinVo>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    workJoinVo workjoin = new workJoinVo(
                        rd["불량명"].ToString(),
                        int.Parse(rd["불량합계"].ToString()));
                    list.Add(workjoin);
                }
            }
            else
            {
                Console.WriteLine("불량유형관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Company> getCompanyVo()
        {
            string sql = "select companynum as 사업장번호, " +
                "companyname as 사업장명 from company_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Company> list = new List<Company>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Company company = new Company(
                        rd["사업장번호"].ToString(),
                        rd["사업장명"].ToString());
                    list.Add(company);
                }
            }
            else
            {
                Console.WriteLine("사업장관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<BOM> getBOMVo()
        {
            string sql = string.Format("select pNum, cNum, quantity from BOM_t");
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<BOM> list = new List<BOM>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    BOM bom = new BOM(
                        rd["pNum"].ToString(),
                        rd["cNum"].ToString(),
                        int.Parse(rd["quantity"].ToString()));
                    list.Add(bom);
                }
            }
            else
            {
                Console.WriteLine("BOM관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<BOM> getBOMVo(string item)
        {
            string sql = string.Format("select pNum, cNum, quantity from BOM_t where pNum = '{0}'",item);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<BOM> list = new List<BOM>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    BOM bom = new BOM(
                        rd["pNum"].ToString(),
                        rd["cNum"].ToString(),
                        int.Parse(rd["quantity"].ToString()));
                    list.Add(bom);
                }
            }
            else
            {
                Console.WriteLine("BOM관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Supplier> getSupplierVo()
        {
            string sql = string.Format("select SUPPLIERNUM, SUPPLIERNAME, " +
                "SELLINGITEM, CEONAME, ADRESS from SUPPLIER_t");
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Supplier> list = new List<Supplier>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Supplier supplier = new Supplier(
                        int.Parse(rd["SUPPLIERNUM"].ToString()),
                        rd["SUPPLIERNAME"].ToString(),
                        rd["SELLINGITEM"].ToString(),
                        rd["CEONAME"].ToString(),
                        rd["ADRESS"].ToString());
                    list.Add(supplier);
                }
            }
            else
            {
                Console.WriteLine("BOM관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Company> getCompanyVo(string companyName)
        {
            string sql = string.Empty;
            if (companyName != "")
            {
                sql = string.Format("select companynum as 사업장번호, " +
                "companyname as 사업장명 from company_t " +
                "where companyname = '{0}'", companyName);
            }
            else
            {
                sql = "select companynum as 사업장번호, " +
                "companyname as 사업장명 from company_t ";
            }
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Company> list = new List<Company>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Company company = new Company(
                        rd["사업장번호"].ToString(),
                        rd["사업장명"].ToString());
                    list.Add(company);
                }
            }
            else
            {
                Console.WriteLine("사업장관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Machine> getMachineVo(string machineLine)
        {
            string sql = string.Empty;
            if (machineLine != "")
            {
                sql = string.Format("select machineLine as 설비라인, " +
                "machineName as 설비라인명 from machine_t " +
                "where machineLine = '{0}'", machineLine);
            }
            else
            {
                sql = "select machineLine as 설비라인, " +
                "machineName as 설비라인명 from machine_t ";
            }
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Machine> list = new List<Machine>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Machine machine = new Machine(
                        rd["설비라인"].ToString(),
                        rd["설비라인명"].ToString());
                    list.Add(machine);
                }
            }
            else
            {
                Console.WriteLine("설비관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Supplier> getSupplierVo(string supplier)
        {
            string sql = string.Empty;
            if (supplier != "")
            {
                sql = string.Format("select supplierNum, supplierName, sellingItem," +
                    "ceoName, adress from supplier_t where supplierName like '{0}'", supplier);
            }
            else
            {
                sql = "select supplierNum, supplierName, sellingItem," +
                    "ceoName, adress from supplier_t";
            }
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Supplier> list = new List<Supplier>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Supplier sup = new Supplier(
                        int.Parse(rd["supplierNum"].ToString()),
                        rd["supplierName"].ToString(),
                        rd["sellingItem"].ToString(),
                        rd["ceoName"].ToString(),
                        rd["adress"].ToString());
                    list.Add(sup);
                }
            }
            else
            {
                Console.WriteLine("거래처관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }

        public List<Notice> getNoticeVo()
        {
            string sql = "select contentsNum as 번호, contents as 내용," +
                "writeName as 작성자, writeDate as 작성일 from notice_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Notice> list = new List<Notice>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Notice notice = new Notice(
                        int.Parse(rd["번호"].ToString()),
                        rd["내용"].ToString(),
                        rd["작성자"].ToString(),
                        rd["작성일"].ToString());
                    list.Add(notice);
                }
            }
            else
            {
                Console.WriteLine("공지사항관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Items> getItemsVo()
        {
            string sql = "select itemcode, itemname from item_t";
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();

            List<Items> list = new List<Items>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Items items = new Items(
                        rd["itemcode"].ToString(),
                        rd["itemname"].ToString());
                    list.Add(items);
                }
            }
            else
            {
                Console.WriteLine("품목 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Items> getItemsVo(string itemCode)
        {
            string sql = string.Empty;
            if (itemCode != "")
            {
                sql = string.Format("select itemcode as 품목번호, " +
                "itemname as 품목명 from item_t " +
                "where itemcode = '{0}'", itemCode);
            }
            else
            {
                sql = "select itemcode as 품목번호, " +
                "itemname as 품목명 from item_t ";
            }
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            List<Items> list = new List<Items>();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Items items = new Items(
                        rd["품목번호"].ToString(),
                        rd["품목명"].ToString());
                    list.Add(items);
                }
            }
            else
            {
                Console.WriteLine("품목관련 데이터가 존재하지 않습니다.");
            }
            rd.Close();
            return list;
        }
        public List<Work> getWorkVo()
        {
            string sql = string.Format("select workordernum, companynum," +
                "machineline, workerid, itemcode, workquantity, workdate, worknote" +
                " from workorder_t order by workordernum");
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rb = cmd.ExecuteReader();

            List<Work> list = new List<Work>();

            if (rb.HasRows)
            {
                while (rb.Read())
                {
                    Work work = new Work(
                        int.Parse(rb["workordernum"].ToString()),
                        int.Parse(rb["companynum"].ToString()),
                        rb["machineline"].ToString(),
                        int.Parse(rb["workerid"].ToString()),
                        rb["itemcode"].ToString(),
                        int.Parse(rb["workquantity"].ToString()),
                        rb["workdate"].ToString(),
                        rb["worknote"].ToString());

                    list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rb.Close();
            return list;
        }

        public List<Work> getsearchWorkVo(string[,] searchWork, string[,] searchDate)
        {
            string select = string.Format("select workordernum, " +
                "{0},{1},{2},{3},{4},{5},{6}",
                searchWork[0, 0], searchWork[1, 0], searchWork[2, 0],
                searchWork[3, 0], searchWork[4, 0], searchWork[5, 0],
                searchDate[0,0]);
            string where = "where 1=1 and workordernum NOT IN (SELECT workordernum from worked_t)";
            for (int i = 0; i < searchWork.GetLength(0); i++)
            {
                if (searchWork[i, 1] != "")
                {
                    where += string.Format(" and " +
                        "{0} like '{1}'", searchWork[i, 0], searchWork[i, 1]);
                }
            }
            for (int i = 0; i < searchDate.GetLength(0); i++)
            {
                if (searchDate[i, 1] != "")
                {
                    where += string.Format(" and " +
                        "{0} >= '{1}'", searchDate[i, 0], searchDate[i, 1]);
                }
                if (searchDate[i, 2] != "")
                {
                    where += string.Format(" and " +
                        "{0} <= '{1}'", searchDate[i, 0], searchDate[i, 2]);
                }
            }

            string sql = select + " from workorder_t " + where;

            Console.WriteLine("작업완료 제외 해야함:" + sql);

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rb = cmd.ExecuteReader();

            List<Work> list = new List<Work>();

            if (rb.HasRows)
            {
                while (rb.Read())
                {
                    Work work = new Work(
                        int.Parse(rb["workordernum"].ToString()),
                        int.Parse(rb["companynum"].ToString()),
                        rb["machineline"].ToString(),
                        int.Parse(rb["workerid"].ToString()),
                        rb["itemcode"].ToString(),
                        int.Parse(rb["workquantity"].ToString()),
                        rb["workdate"].ToString(),
                        rb["worknote"].ToString());

                    list.Add(work);
                }
            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.");
            }
            rb.Close();
            return list;
        }
        public List<workJoinVo> getWorkJoinVo(string[,] searchWork, string[,] searchDate)
        {
            string select = "select A.workednum, B.companynum, B.machineline, " +
                "B.workerid, B.itemcode, B.workquantity, B.workdate, A.workeddate," +
                "A.workedquantity, A.defectquantity, A.defectcode, B.worknote";

            string from = " from worked_t A" +
                          " left join workorder_t B on A.workordernum = b.workordernum";

            string where = " where 1=1";
            for (int i = 0; i < searchWork.GetLength(0); i++)
            {
                if (searchWork[i, 1] != "")
                {
                    where += string.Format(" and " +
                        "B.{0} = '{1}'", searchWork[i, 0], searchWork[i, 1]);
                }
            }

            for(int i = 0; i < searchDate.GetLength(0); i++)
            {
                if (searchDate[i, 1] != "")
                {
                    where += string.Format(" and " +
                        "{0} >= '{1}'", searchDate[i, 0], searchDate[i, 1]);
                }
                if (searchDate[i, 2] != "")
                {
                    where += string.Format(" and " +
                        "{0} <= '{1}'", searchDate[i, 0], searchDate[i, 2]);
                }
            }

            string sql = select + from + where;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rb = cmd.ExecuteReader();

            List<workJoinVo> list = new List<workJoinVo>();

            if (rb.HasRows)
            {
                while (rb.Read())
                {
                    workJoinVo workjoinvo = new workJoinVo(
                        int.Parse(rb["workednum"].ToString()),
                        rb["companynum"].ToString(),
                        rb["machineline"].ToString(),
                        int.Parse(rb["workerid"].ToString()),
                        rb["itemcode"].ToString(),
                        int.Parse(rb["workquantity"].ToString()),
                        rb["workdate"].ToString(),
                        rb["workeddate"].ToString(),
                        int.Parse(rb["workedquantity"].ToString()),
                        int.Parse(rb["defectquantity"].ToString()),
                        rb["defectcode"].ToString(),
                        rb["worknote"].ToString());
                    list.Add(workjoinvo);
                }
            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.");
            }
            rb.Close();
            return list;
        }

        public List<workJoinVo> getItemJoinVo(string item)
        {
            string select = "select item_t.itemcode as 품번, item_t.itemname as 품명," +
                            "sum(workorder_t.workquantity) as 계획수량, sum(worked_t.workedquantity) as 실적수량";
            string from = " from item_t, workorder_t, worked_t ";
            string where = " where item_t.itemcode = workorder_t.itemcode and " +
                "workorder_t.workordernum = worked_t.workordernum ";

            if (item != "전체")
            {
                where += string.Format(" and item_t.itemcode = '{0}'", item);
            }

            string group = " group by item_t.itemcode, item_t.itemname";

            string sql = select + from + where + group;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rb = cmd.ExecuteReader();

            List<workJoinVo> list = new List<workJoinVo>();
            if (rb.HasRows)
            {
                while (rb.Read())
                {
                    workJoinVo workjoinvo = new workJoinVo(
                        rb["품번"].ToString(),
                        rb["품명"].ToString(),
                        int.Parse(rb["계획수량"].ToString()),
                        int.Parse(rb["실적수량"].ToString()));
                    list.Add(workjoinvo);
                }
            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.");
            }
            rb.Close();
            return list;
        }
        public List<workJoinVo> getMachineJoinVo(string machine)
        {
            string select = "select workorder_t.machineline as 설비라인, " +
                "sum(workorder_t.workquantity) as 계획수량," +
                "sum(worked_t.workedquantity) as 실적수량";
            string from = " from workorder_t, worked_t";
            string where = " where workorder_t.workordernum = worked_t.workordernum";

            if (machine != "전체")
            {
                where += string.Format(" and workorder_t.machineline = '{0}'", machine);
            }

            string group = " group by workorder_t.machineline";

            string sql = select + from + where + group;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rb = cmd.ExecuteReader();

            List<workJoinVo> list = new List<workJoinVo>();
            if (rb.HasRows)
            {
                while (rb.Read())
                {
                    workJoinVo workjoinvo = new workJoinVo(
                        rb["설비라인"].ToString(),
                        int.Parse(rb["계획수량"].ToString()),
                        int.Parse(rb["실적수량"].ToString()));
                    list.Add(workjoinvo);
                }
            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.");
            }
            rb.Close();
            return list;
        }
        public List<Work> getWorkVo(string machineLine)
        {
            string select = "select A.workordernum, B.workednum, " +
                "A.companynum, A.machineline, A.workerid, " +
                "A.itemcode, A.workquantity, A.workdate, A.worknote";
            string from = " from workorder_t A " +
                "left join worked_t B on A.workordernum = B.workordernum";
            string where = " where B.workednum is null ";

            if (machineLine != "전체")
            {
                where += string.Format("and A.machineline = '{0}'", machineLine);
            }
            else
            {
                where = " where B.workednum is null ";
            }

            string sql = select + from + where;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rb = cmd.ExecuteReader();

            List<Work> list = new List<Work>();

            if (rb.HasRows)
            {
                while (rb.Read())
                {
                    Work work = new Work(
                        int.Parse(rb["workordernum"].ToString()),
                        int.Parse(rb["companynum"].ToString()),
                        rb["machineline"].ToString(),
                        int.Parse(rb["workerid"].ToString()),
                        rb["itemcode"].ToString(),
                        int.Parse(rb["workquantity"].ToString()),
                        rb["workdate"].ToString(),
                        rb["worknote"].ToString());

                    list.Add(work);
                }
            }
            else
            {
                MessageBox.Show("데이터가 존재하지 않습니다.");
            }
            rb.Close();
            return list;
        }
        public List<Work> getWorkOrderVo(string workordernum)
        {
            string sql = string.Format("select workordernum, companynum," +
                "machineline, workerid, itemcode, workquantity, workdate, worknote" +
                " from workorder_t where workordernum = {0} order by workordernum", workordernum);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rb = cmd.ExecuteReader();

            List<Work> list = new List<Work>();

            if (rb.HasRows)
            {
                while (rb.Read())
                {
                    Work work = new Work(
                        int.Parse(rb["workordernum"].ToString()),
                        int.Parse(rb["companynum"].ToString()),
                        rb["machineline"].ToString(),
                        int.Parse(rb["workerid"].ToString()),
                        rb["itemcode"].ToString(),
                        int.Parse(rb["workquantity"].ToString()),
                        rb["workdate"].ToString(),
                        rb["worknote"].ToString());

                    list.Add(work);
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            rb.Close();
            return list;
        }

        public void updateDB(int purchaseNum)
        {
            try
            {
                string sql = string.Format("update purchase_t set STATUS = '입고완료' where purchaseNum = {0}",
                    purchaseNum);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("구매 정보 업데이트 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateStockDB(string itemCode, int stockQuantity)
        {
            try
            {
                string sql = string.Format("update stock_t set stockQuantity = stockQuantity + {0}" +
                    " where itemCode = '{1}'",
                    stockQuantity, itemCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("재고 정보 업데이트 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateStockSubDB(string itemCode, int stockQuantity)
        {
            try
            {
                string sql = string.Format("update stock_t set stockQuantity = stockQuantity - {0}" +
                    " where itemCode = '{1}'",
                    stockQuantity, itemCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                MessageBox.Show("재고 정보 업데이트 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int checkDB(string itemCode, int stockQuantity)
        {
            int check = 0;
            try
            {
                string sql = string.Format("select stockQuantity - {0} as 수량 " +
                    " from stock_t " +
                    " where itemCode = '{1}'",
                    stockQuantity, itemCode);
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader rd = cmd.ExecuteReader();
                int value = 0;
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        value = int.Parse(rd["수량"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("데이터가 존재하지 않습니다.");
                }
                rd.Close();

                if (value >= 0)
                {
                    check = 1;
                }
                else if(value < 0)
                {
                    check = 0;
                }
            }
            catch (OracleException e)
            {
                MessageBox.Show("재고 정보 업데이트 오류: " + e.Message, "오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;

        }

        public string login(string passwd)
        {
            string check = string.Empty;
            string sql = string.Format("select count(*) as ret, " +
                "decode(count(*),1,'성공',0,'실패','None') as value" +
                " from ADMIN_T " +
                " where id = 'admin' and func_decrypt(pwd) = '{0}'", passwd);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    check = rd["value"].ToString();
                    Console.WriteLine("암호 확인:" + check);
                }
            }
            else
            {
                Console.WriteLine("암호가 일치하지 않습니다.");
            }
            rd.Close();
            return check;
        }
    }
}
