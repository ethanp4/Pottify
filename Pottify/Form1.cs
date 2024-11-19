using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace Pottify {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Debug.WriteLine(path);
            var songsPath = "..\\..\\..\\Songs";


            DirectoryInfo d = new DirectoryInfo(songsPath); 

            FileInfo[] files = d.GetFiles("*.mp3");
            string str = "";

            Debug.WriteLine(files);

            songsList.Items.AddRange(files);
            foreach (FileInfo file in files) {
                Debug.WriteLine(file.FullName);
            }
        }
    }
}
