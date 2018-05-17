using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name ={ "葉俊廷", "張澤瑜", "王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜",
                "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔",
                "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )", "陳昱嘉",
                "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷",
                "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "張鈺慈", "鍾宜珊", "raer_tsai",
                "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮" };

            List<string> studentList = new List<string>();
            List<List<string>> teamList = new List<List<string>>();
            int teamCount = 0;

            for(int i =0;i<name.Length;i++)
            {
                studentList.Add(name[i]);
            }

            Random r = new Random();

            while(studentList.Count>6)
            {
                teamList.Add(new List<string>());

                for(int i=0;i<6;i++)
                {
                    int rand = r.Next(0, studentList.Count);
                    teamList[teamCount].Add(studentList[rand]);
                    studentList.Remove(studentList[rand]);
                }

                teamCount++;
            }

            teamList.Add(new List<string>());

            while(studentList.Count>0)
            {
                int rand = r.Next(0, studentList.Count);
                teamList[teamCount].Add(studentList[rand]);
                studentList.Remove(studentList[rand]);
            }

            foreach(List<string> s in teamList)
            {
                foreach(string ss in s)
                {
                    Console.WriteLine(ss);
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
