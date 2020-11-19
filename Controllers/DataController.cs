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
        private const string FILE = "data.json";
        private List<Data> Datas = new List<Data>();
        /// <summary>
        /// 初始化
        /// </summary>
        public DataController()
        {
            InitializeData();
        }
        /// <summary>
        /// 初始化讀取單字
        /// </summary>
        private void InitializeData()
        {
            using (StreamReader r = new StreamReader(FILE))
            {
                string json = r.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Datas = js.Deserialize<List<Data>>(json);
            }
        }
        public void addData(string English,string Chinese)
        {
            
        }
        /// <summary>
        /// 取得所有單字
        /// </summary>
        /// <returns></returns>
        public List<Data> GetDatas()
        {
            return Datas;
        }
    }
}
