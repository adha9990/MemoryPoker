using MemoryPoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryPoker.Controllers
{
    class PokerController
    {
        private List<Poker> pokers = new List<Poker>();
        private List<Data> poker_list = new List<Data>();
        private const int score_point = 100;
        private int score = 0;

        public PokerController()
        {
            InitializeData();
        }
        /// <summary>
        /// 初始化資料
        /// </summary>
        public void InitializeData()
        {
            score = 0;
            CreateNewPokers();
            RandomPokers();
        }
        /// <summary>
        /// 創造新撲克牌
        /// </summary>
        private void CreateNewPokers()
        {
            DataController dataController = new DataController();
            pokers = new List<Poker>();
            
            foreach (Data data in dataController.GetDatas())
            {
                pokers.Add(new Poker(data.Id, data.English));
                pokers.Add(new Poker(data.Id, data.Chinese));
                poker_list.Add(new Data(data.English, data.Chinese));
            }
        }
        /// <summary>
        /// 打亂撲克牌陣列
        /// 不夠亂嗎?打亂五次拉!
        /// </summary>
        private void RandomPokers()
        {
            Random random = new Random();
            pokers = pokers.OrderBy(x => random.Next(0, pokers.Count())).ToList<Poker>();
            pokers = pokers.OrderBy(x => random.Next(0, pokers.Count())).ToList<Poker>();
            pokers = pokers.OrderBy(x => random.Next(0, pokers.Count())).ToList<Poker>();
            pokers = pokers.OrderBy(x => random.Next(0, pokers.Count())).ToList<Poker>();
            pokers = pokers.OrderBy(x => random.Next(0, pokers.Count())).ToList<Poker>();
        }
        /// <summary>
        /// 取得所有撲克牌
        /// </summary>
        /// <returns></returns>
        public List<Poker> GetPokers()
        {
            return pokers;
        }
        /// <summary>
        /// 比對撲克牌是否正確
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        public Boolean CheckEquals(int a_id, int b_id)
        {
            return String.Equals(a_id, b_id);
        }
        /// <summary>
        /// 獲得分數
        /// </summary>
        public void AddScore()
        {
            score += score_point;
        }
        /// <summary>
        /// 回傳總分
        /// </summary>
        /// <returns></returns>
        public int GetScore()
        {
            return score;
        }
        /// <summary>
        /// 回傳撲克牌清單
        /// </summary>
        /// <returns></returns>
        public List<Data> GetPokerList()
        {
            return poker_list;
        }
    }
}
