using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace firsth_Program
{
    class Program
    {

        static void Main(string[] args)
        {

           // 띄어쓰기로 구분해줍니다.
           // ex. 버스 카드 충전 > 버카충
            Console.WriteLine("인싸가 되기 위한 줄임말 번역기");
            Console.Write("입력: ");

            string uhang = Console.ReadLine();
            string[] add_word = new string[100];
            string[] wordList = uhang.Split(); 

            for(int i=0; i<wordList.Length; i++)
            {
                add_word[i] = wordList[i];
                Console.Write(add_word[i][0]);
            }

        }
    }
}
