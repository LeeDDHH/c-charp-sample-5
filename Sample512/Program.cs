using System.Threading;
namespace Sample512
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone("hoge@email.com", "090-1234-5678");
            cp.Call("011-123-4567");
            cp.SendMail("fuga@email.com");

            // 電話インターフェースでインスタンスにアクセス
            IPhone phone = (IPhone)cp;
            phone.Call("011-123-4567");
            // メールの送信メソッドは利用できない
            // phone.SendMail("foo@gmail.com");

            // メールインターフェースでインスタンスにアクセス
            IEmail mail = (IEmail)cp;
            mail.SendMail("bar@email.com");
            // 電話の機能は利用できない
            // mail.Call("011-222-3333");
        }
    }
}
