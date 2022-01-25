using clutch_MES.DAO;
using clutch_MES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clutch_MES.Adapter
{
    class BaseAdapter
    {
        List<Work> workList = new List<Work>();
        List<Worked> workedList = new List<Worked>();
        List<Machine> machineList = new List<Machine>();
        List<Items> itemsList = new List<Items>();
        List<Defect> defectList = new List<Defect>();
        List<Worker> workerList = new List<Worker>();
        List<Company> companyList = new List<Company>();
        List<Notice> noticeList = new List<Notice>();

        public void addToList(Work work)
        {
            workList.Add(work);
            addToDB(work);
        }
        public void addToDB(Work work)
        {
            OraMgr.Instance.insertDB(work);
        }
        public void addToDB(Supplier supplier)
        {
            OraMgr.Instance.insertDB(supplier);
        }
        public void addToDB(BOM bom)
        {
            OraMgr.Instance.insertDB(bom);
        }
        public void addInStockHistoryDB(StockHistory stockhistory)
        {
            OraMgr.Instance.insertInStockHistoryDB(stockhistory);
        }
        public void addOutStockHistoryDB(StockHistory stockhistory)
        {
            OraMgr.Instance.insertOutStockHistoryDB(stockhistory);
        }
        public void addToDB(Worked worked)
        {
            OraMgr.Instance.insertDB(worked);
        }
        public void addToDB(Purchase purchase)
        {
            OraMgr.Instance.insertDB(purchase);
        }
        public void addToDB(Defect defect)
        {
            OraMgr.Instance.insertDB(defect);
        }
        public void addToDB(Machine machine)
        {
            OraMgr.Instance.insertDB(machine);
        }
        public void addToDB(Company company)
        {
            OraMgr.Instance.insertDB(company);
        }
        public void addToDB(Items items)
        {
            OraMgr.Instance.insertDB(items);
        }
        public void addToDB(Notice notice)
        {
            OraMgr.Instance.insertDB(notice);
        }

        public void deleteFromDB(string machineLine)
        {
            OraMgr.Instance.DeleteDB(machineLine);
        }
        public void deleteFromDB(int contentsNum)
        {
            OraMgr.Instance.DeleteDB(contentsNum);
        }
        public void deleteWorkerDB(int workerID)
        {
            OraMgr.Instance.DeleteWorkerDB(workerID);
        }
        public void deleteDefectDB(string defectCode)
        {
            OraMgr.Instance.DeleteDefectDB(defectCode);
        }
        public void deleteCompanyDB(int companyNum)
        {
            OraMgr.Instance.DeleteCompanyDB(companyNum);
        }
        public void deleteBOMDB(string pNum, string cNum, int quantity)
        {
            OraMgr.Instance.DeleteBOMDB(pNum, cNum, quantity);
        }
        public void deleteSupplierDB(Supplier supplier)
        {
            OraMgr.Instance.DeleteSupplierDB(supplier);
        }
        public void deleteItemDB(string itemCode)
        {
            OraMgr.Instance.DeleteItemDB(itemCode);
        }

        public List<Machine> getMachineList()
        {
            List<Machine> list = OraMgr.Instance.getMachineVo();
            return list;
        }
        public List<Machine> getMachineList(string machineLine)
        {
            List<Machine> list = OraMgr.Instance.getMachineVo(machineLine);
            return list;
        }
        public List<Supplier> getSupplierList(string supplier)
        {
            List<Supplier> list = OraMgr.Instance.getSupplierVo(supplier);
            return list;
        }
        public List<Notice> getNoticeList()
        {
            List<Notice> list = OraMgr.Instance.getNoticeVo();
            return list;
        }
        public List<Worker> getWorkerList()
        {
            List<Worker> list = OraMgr.Instance.getWorkerVo();
            return list;
        }
        public List<Worker> getWorkerList(string workerName)
        {
            List<Worker> list = OraMgr.Instance.getWorkerVo(workerName);
            return list;
        }
        public List<Defect> getDefectList()
        {
            List<Defect> list = OraMgr.Instance.getDefectVo();
            return list;
        }
        public List<workJoinVo> getDefectJoinList()
        {
            List<workJoinVo> list = OraMgr.Instance.getDefectJoinVo();
            return list;
        }

        public List<Items> getItemsList()
        {
            List<Items> list = OraMgr.Instance.getItemsVo();
            return list;
        }
        public List<Items> getItemsList(string itemcode)
        {
            List<Items> list = OraMgr.Instance.getItemsVo(itemcode);
            return list;
        }

        public List<BOM> getBOMList(string item)
        {
            List<BOM> list = OraMgr.Instance.getBOMVo(item);
            return list;
        }
        public List<BOM> getBOMList()
        {
            List<BOM> list = OraMgr.Instance.getBOMVo();
            return list;
        }
        public List<Supplier> getSupplierList()
        {
            List<Supplier> list = OraMgr.Instance.getSupplierVo();
            return list;
        }

        public List<Company> getCompanyList(string companyName)
        {
            List<Company> list = OraMgr.Instance.getCompanyVo(companyName);
            return list;
        }
        public List<Company> getCompanyList()
        {
            List<Company> list = OraMgr.Instance.getCompanyVo();
            return list;
        }


        public List<Work> getWorkDB()
        {
            List<Work> worklist = OraMgr.Instance.getWorkVo();
            return worklist;
        }

        public List<Stock> getAllStock()
        {
            List<Stock> stocklist = OraMgr.Instance.getAllStock();
            return stocklist;
        }

        public List<Work> getWorkDB(string[,] searchCondition, string[,] searchDate)
        {
            List<Work> list = OraMgr.Instance.getsearchWorkVo(searchCondition, searchDate);
            return list;
        }

        public string getItemCodeName(string itemCode)
        {
            string itemCodeName = OraMgr.Instance.getItemCodeName(itemCode);
            return itemCodeName;
        }
        public List<Purchase> getPurchaseDB(string[,] searchCondition, string[,] searchDate)
        {
            List<Purchase> list = OraMgr.Instance.getsearchPurchaseVo(searchCondition, searchDate);
            return list;
        }

        public List<StockHistory> getStockHistoryDB(string[,] searchCondition, string[,] searchDate)
        {
            List<StockHistory> list = OraMgr.Instance.getsearchStockHistoryVo(searchCondition, searchDate);
            return list;
        }


        public List<workJoinVo> getItemJoinList(string item)
        {
            List<workJoinVo> list = OraMgr.Instance.getItemJoinVo(item);
            return list;
        }

        public List<workJoinVo> getMachineJoinList(string machine)
        {
            List<workJoinVo> list = OraMgr.Instance.getMachineJoinVo(machine);
            return list;
        }

        public List<workJoinVo> getWorkJoinDB(string[,] searchCondition, string[,] searchDate)
        {
            List<workJoinVo> list = OraMgr.Instance.getWorkJoinVo(searchCondition, searchDate);
            return list;
        }

        public List<Work> getWorkDB(string machineLine)
        {
            List<Work> worklist = OraMgr.Instance.getWorkVo(machineLine);
            return worklist;
        }
        public List<Work> getWorkOrderDB(string workordernum)
        {
            List<Work> worklist = OraMgr.Instance.getWorkOrderVo(workordernum);
            return worklist;
        }

        public void updateDB(int purchaseNum)
        {
            OraMgr.Instance.updateDB(purchaseNum);
        }

        public void updateStockDB(string itemCode, int quantity)
        {
            OraMgr.Instance.updateStockDB(itemCode, quantity);
        }
        public void updateStockSubDB(string itemCode, int quantity)
        {
            OraMgr.Instance.updateStockSubDB(itemCode, quantity);
        }
        public int checkStock(string itemCode, int quantity)
        {
            int check = OraMgr.Instance.checkDB(itemCode, quantity);
            return check;
        }
    }
}
