using System.Diagnostics;
using System.Reflection;
using System.IO;
using Id3;

namespace Pottify {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            //https://github.com/JeevanJames/Id3
            var songsPath = "..\\..\\..\\Songs";
            //DirectoryInfo d = new DirectoryInfo(songsPath); 
            string[] files = Directory.GetFiles(songsPath, "*.mp3");

            foreach (var file in files) {
                setNothing(file);
            }


            void setNothing(string mp3FilePath) {
                using (var mp3 = new Mp3(mp3FilePath, Mp3Permissions.ReadWrite)) {
                    Id3Tag tag = mp3.GetTag(Id3TagFamily.Version2X); //get the existing tag
                    tag = new();
                    tag.Year.Value = 2000;
                    tag.Title = "Unknown";
                    mp3.WriteTag(tag, WriteConflictAction.Replace); //rewrite that tag to the file
                }
            }

            songsList.Items.AddRange(files);

            var songs = new AutoCompleteStringCollection();
            songs.AddRange(files);
            textSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearch.AutoCompleteCustomSource = songs;
        }
    }
}
