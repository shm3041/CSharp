using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace Ex3_BankAccount
{
    class BankAccount
    {
        string name;
        string id;
        Int128 money;
        public BankAccount(string name, string id)
        {
            this.name = name;
            this.id = id;
            this.money = 0;
            Console.WriteLine("[개인 계좌 생성]");
            Console.WriteLine($"이름: {name}, 계좌번호: {id}, 잔액: {money}원\n");
        }

        public void Deposit(int money) {
            this.money += money;
            Console.WriteLine("[입금]");
            Console.WriteLine($"{name}님의 계좌에 {money}원이 입금되었습니다.");
            Console.WriteLine($"현재 잔액: {this.money}원\n");
        }

        public void Withdraw(int money) {
            if (this.money < money)
            {
                Console.WriteLine("[출금 실패]");
                Console.WriteLine($"잔액이 부족합니다. 현재 잔액: {this.money}원");
                return;
            }
            this.money -= money;
            Console.WriteLine("[출금]");
            Console.WriteLine($"{name}님의 계좌에서 {money}원이 출금되었습니다.");
            Console.WriteLine($"현재 잔액: {this.money}원\n");
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine("--- 개인 계좌 정보 ---");
            Console.WriteLine($"이름: {name}\n계좌번호: {id}\n잔액: {money}원\n");
        }

        //static string[] aName = new string[50];
        static List<string> aName = new List<string>();
        static int aMoney = 0;
        static int aList;
        public static void AddParticipant(string name)
        {
            Console.WriteLine($"{name}님이 모임통장에 참여했습니다.");
            //aName[aList] = name;
            aName.Add(name);
            aList++;
        }
        public static void DepositToGroup(int money)
        {
            aMoney += money;
            Console.WriteLine("[모임통장 입금]");
            Console.WriteLine($"모임통장에 {money}원이 입금되었습니다.");
            Console.WriteLine($"현재 모임통장 잔액: {aMoney}원\n");
        }

        public static void WithdrawFromGroup(int money) 
        { 
            aMoney -= money;
            Console.WriteLine("[모임통장 출금]");
            if (aMoney < money)
            {
                Console.WriteLine("[출금 실패]");
                Console.WriteLine($"잔액이 부족합니다. 현재 잔액: {aMoney}원");
                return;
            }
            Console.WriteLine($"모임통장에서 {money}원이 출금되었습니다.");
            Console.WriteLine($"현재 모임통장 잔액: {aMoney}원\n");
        }

        public static void PrintGroupAccountInfo()
        {
            Console.WriteLine("--- 모임통장 정보 ---");
            Console.WriteLine($"참여자 수: {aList}명");
            Console.Write("참여자 명단: ");
            //for(int i = 0; i < aName.Length; i++)
            //{
            //    if(aName[i] != null) Console.Write($"{aName[i]}, ");
            //}
            foreach (var item in aName)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("\b\b");
            Console.Write(" ");
            Console.WriteLine($"\n잔액: {aMoney}원\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 개인 계좌 생성
            BankAccount account1 = new BankAccount("김철수", "1001");
            BankAccount account2 = new BankAccount("이영희", "1002");
            // 개인 계좌 입출금
            account1.Deposit(50000);
            account1.Withdraw(20000);
            // 모임통장 참여자 추가
            Console.WriteLine("[모임통장 참여자 추가]");
            BankAccount.AddParticipant("김철수");
            BankAccount.AddParticipant("이영희");
            Console.WriteLine();
            // 모임통장 입출금
            BankAccount.DepositToGroup(100000);
            BankAccount.WithdrawFromGroup(30000);
            // 계좌 정보 출력
            Console.WriteLine("[계좌 정보 출력]");
            account1.PrintAccountInfo();
            BankAccount.PrintGroupAccountInfo();
            // 추가 테스트 - 잔액 부족 시 출금 시도
            Console.WriteLine("[추가 테스트 - 잔액 부족]");
            account2.Deposit(5000);
            account2.Withdraw(10000); // 잔액 부족 메시지가 출력되어야 함
        }

    }
}
