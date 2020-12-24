using MemoryPoker.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace MemoryPoker.Controllers
{
    class DataController
    {
        private const string FILE = "Resource/data.json";
        private List<Data> datas = new List<Data>();
        /// <summary>
        /// 初始化
        /// </summary>
        public DataController()
        {
            readDatabase();
        }
        /// <summary>
        /// 讀取資料庫
        /// </summary>
        private void readDatabase()
        {
            using (StreamReader r = new StreamReader(FILE))
            {
                string json = r.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                datas = js.Deserialize<List<Data>>(json);
            }
        }
        /// <summary>
        /// 寫入資料庫
        /// </summary>
        private void writeDatabase()
        {
            using (StreamWriter file = File.CreateText(FILE))
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                string json = js.Serialize(datas);
                file.Write(json);
            }
        }
        /// <summary>
        /// 新增單字
        /// </summary>
        /// <param name="English"></param>
        /// <param name="Chinese"></param>
        public void addData(string English,string Chinese)
        {
            datas.Add(new Data(datas[datas.Count-1].Id+1, English, Chinese));
            writeDatabase();
        }
        /// <summary>
        /// 修改單字
        /// </summary>
        /// <param name="id"></param>
        /// <param name="English"></param>
        /// <param name="Chinese"></param>
        public void editData(int id,string English,string Chinese)
        {
            foreach (Data data in datas)
            {
                if (data.Id == id)
                {
                    data.English = English;
                    data.Chinese = Chinese;
                    break;
                }
            }
            writeDatabase();
        }
        /// <summary>
        /// 刪除單字
        /// </summary>
        /// <param name="id"></param>
        public void deleteData(int id)
        {
            int index = 0;
            foreach (Data data in datas)
            {
                if(data.Id == id)
                {
                    datas.RemoveAt(index);
                    break;
                }
                index++;
            }
            writeDatabase();
        }        
        /// <summary>
        /// 取得所有單字
        /// </summary>
        /// <returns></returns>
        public List<Data> GetDatas()
        {
            return datas;
        }
    }
}
