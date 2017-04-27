using Xamarin.Forms;

namespace NotificationSample
{
    public partial class App : Application
    {
        readonly NavigationPage _navigationPage;

        public App(string startUpParam)
        {
            InitializeComponent();

            // 画面が破棄された状態で通知をタップすると startUpParam にデータが入ってくるので、
            // それを使って適宜なんとかする。
            // Prism.Forms を使っていれば URL ベースのナビゲーションが使えるのでいいかもね。
            if (!string.IsNullOrEmpty(startUpParam))
            {
                System.Diagnostics.Debug.WriteLine($"アプリが通知から起動されたよ. param={startUpParam}");
            }

            // NavigationPage を保持しておいて CurrentPage を外部に公開する
            _navigationPage = new NavigationPage(new MainPage());
            MainPage = _navigationPage;
        }

        // 出、出〜！カッコつけてラムダで getter 書奴〜ｗｗｗｗ
        public Page CurrentPage => _navigationPage.CurrentPage;
    }
}
