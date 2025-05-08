using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class Form2 : Form
    {
        private Dictionary<string, List<(string Word, string Clue, string Difficulty)>> wordList = new Dictionary<string, List<(string, string, string)>>
        {
            { "History", new List<(string, string, string)>
                {
                    ("imparatorluk", "Büyük bir siyasi yapı", "Easy"),
                    ("medeniyet", "Bir toplumun kültürel seviyesi", "Easy"),
                    ("inkılap", "Toplumda köklü değişiklik", "Easy"),
                    ("sömürge", "Bir ülkenin başka bir ülkeyi ekonomik olarak kullanması", "Easy"),
                    ("barış", "Savaşın olmadığı durum", "Easy"),
                    ("şövalye", "Orta Çağ'da bir savaşçı", "Easy"),
                    ("fetih", "Bir yerin ele geçirilmesi", "Easy"),
                    ("rönesans", "Bir kültürel hareket", "Medium"),
                    ("koloni", "Bir ülkenin başka bir ülke üzerindeki hakimiyeti", "Medium"),
                    ("monarşi", "Tek kişinin yönetimi", "Medium"),
                    ("savaş", "İki veya daha fazla tarafın çatışması", "Medium"),
                    ("meclis", "Halkın temsilcilerinin toplandığı yer", "Medium"),
                    ("krallık", "Bir kralın yönettiği ülke", "Medium"),
                    ("devrim", "Güçte önemli bir değişiklik", "Hard"),
                    ("feodalizm", "Orta Çağ'da bir yönetim biçimi", "Hard"),
                    ("antlaşma", "İki taraf arasında yapılan resmi anlaşma", "Hard"),
                    ("demokrasi", "Halkın kendi kendini yönetmesi", "Hard"),
                    ("padişah", "Osmanlı hükümdarı", "Hard"),
                    ("cumhuriyet", "Halkın seçtiği temsilcilerle yönetim", "Hard")
                }
            },
            { "Geography", new List<(string, string, string)>
                {
                    ("nehir", "Akarsu", "Easy"),
                    ("göl", "Karada bulunan su birikintisi", "Easy"),
                    ("yayla", "Yüksek rakımlı düzlük", "Easy"),
                    ("iklim", "Bir bölgenin hava durumu özellikleri", "Easy"),
                    ("buzul", "Donmuş su kütlesi", "Easy"),
                    ("boğaz", "İki denizi birbirine bağlayan dar su yolu", "Easy"),
                    ("akarsu", "Sürekli akan su kütlesi", "Easy"),
                    ("kıta", "Büyük kara parçası", "Medium"),
                    ("vadi", "Dağlar arasında kalan çukur alan", "Medium"),
                    ("delta", "Nehirlerin denize döküldüğü yer", "Medium"),
                    ("volkan", "Lav püskürten dağ", "Medium"),
                    ("körfez", "Denizin karaya sokulduğu yer", "Medium"),
                    ("dağ", "Yüksek yer şekli", "Medium"),
                    ("fay", "Yer kabuğundaki kırık", "Hard"),
                    ("orman", "Ağaçlarla kaplı alan", "Hard"),
                    ("yarımada", "Üç tarafı suyla çevrili kara parçası", "Hard"),
                    ("okyanus", "Büyük su kütlesi", "Hard"),
                    ("plato", "Yüksek ve düz alan", "Hard"),
                    ("ada", "Etrafı suyla çevrili kara parçası", "Hard")
                }
            },
            { "Math", new List<(string, string, string)>
                {
                    ("üçgen", "Üç kenarı olan şekil", "Easy"),
                    ("kare", "Dört eşit kenarı olan şekil", "Easy"),
                    ("çember", "Yuvarlak bir şekil", "Easy"),
                    ("asal", "Sadece 1 ve kendisiyle bölünebilen sayı", "Easy"),
                    ("oran", "İki sayının karşılaştırılması", "Easy"),
                    ("paralel", "Birbirine hiç kesişmeyen doğrular", "Easy"),
                    ("dik", "Birbirine 90 derece olan doğrular", "Easy"),
                    ("pi", "Matematikte bir sabit", "Medium"),
                    ("denklem", "Eşitlik içeren matematiksel ifade", "Medium"),
                    ("matris", "Sayıların tablosu", "Medium"),
                    ("vektör", "Yön ve büyüklük içeren matematiksel ifade", "Medium"),
                    ("katsayı", "Bir terimin çarpanı", "Medium"),
                    ("hipotenüs", "Dik üçgende en uzun kenar", "Medium"),
                    ("çarpan", "Bir sayıyı bölen sayı", "Medium"),
                    ("mod", "Bir sayının kalanını hesaplama", "Medium"),
                    ("logaritma", "Üstel fonksiyonun tersi", "Hard"),
                    ("integral", "Alan hesaplama yöntemi", "Hard"),
                    ("türev", "Değişim oranını hesaplama", "Hard"),
                    ("fonksiyon", "Bir bağıntı türü", "Hard")
                }
            },
            { "Trivia", new List<(string, string, string)>
                {
                    ("telefon", "İletişim için kullanılır", "Easy"),
                    ("kitap", "Metin içeren sayfalar", "Easy"),
                    ("otobüs", "Ulaşım için kullanılır", "Easy"),
                    ("radyo", "Sesli medya aracı", "Easy"),
                    ("tren", "Raylı sistem aracı", "Easy"),
                    ("kalem", "Yazı yazmak için kullanılır", "Easy"),
                    ("kağıt", "Üzerine yazı yazılır", "Easy"),
                    ("saat", "Zamanı gösterir", "Easy"),
                    ("lamba", "Işık sağlar", "Easy"),
                    ("masa", "Üzerine bir şeyler koymak için kullanılır", "Easy"),
                    ("sandaly", "Oturmak için kullanılır", "Easy"),
                    ("kamera", "Fotoğraf çekmek için kullanılır", "Medium"),
                    ("harita", "Yerleri gösterir", "Medium"),
                    ("pusula", "Yön bulmak için kullanılır", "Medium"),
                    ("bilgisayar", "Programlama için kullanılır", "Medium"),
                    ("televizyon", "Görsel medya aracı", "Medium"),
                    ("uçak", "Hava taşımacılığı aracı", "Medium"),
                    ("mikroskop", "Küçük şeyleri görmek için kullanılır", "Hard"),
                    ("teleskop", "Gökyüzünü incelemek için kullanılır", "Hard"),
                    ("ayna", "Yansıma gösterir", "Hard")
                }
            },
            { "Mixed", new List<(string, string, string)>
                {
                    ("imparatorluk", "Büyük bir siyasi yapı", "Easy"),
                    ("telefon", "İletişim için kullanılır", "Easy"),
                    ("üçgen", "Üç kenarı olan şekil", "Easy"),
                    ("göl", "Karada bulunan su birikintisi", "Easy"),
                    ("rönesans", "Bir kültürel hareket", "Medium"),
                    ("vadi", "Dağlar arasında kalan çukur alan", "Medium"),
                    ("pi", "Matematikte bir sabit", "Medium"),
                    ("tren", "Raylı sistem aracı", "Easy"),
                    ("koloni", "Bir ülkenin başka bir ülke üzerindeki hakimiyeti", "Medium"),
                    ("savaş", "İki veya daha fazla tarafın çatışması", "Medium"),
                    ("logaritma", "Üstel fonksiyonun tersi", "Hard"),
                    ("meclis", "Halkın temsilcilerinin toplandığı yer", "Medium"),
                    ("mikroskop", "Küçük şeyleri görmek için kullanılır", "Hard"),
                    ("barış", "Savaşın olmadığı durum", "Easy"),
                    ("fay", "Yer kabuğundaki kırık", "Hard"),
                    ("demokrasi", "Halkın kendi kendini yönetmesi", "Hard"),
                    ("hipotenüs", "Dik üçgende en uzun kenar", "Medium"),
                    ("krallık", "Bir kralın yönettiği ülke", "Medium"),
                    ("teleskop", "Gökyüzünü incelemek için kullanılır", "Hard")
                }
            }
        };


        private string selectedWord;
        private string displayedWord;
        private int points = 100;
        private int incorrectGuesses = 0;
        private int timeLeft = 30;
        private List<char> incorrectLetters = new List<char>();

        private string selectedCategory;
        private string selectedDifficulty;
        private int gameDuration;
        private string selectedImageSet;

        private Form1 parentForm;

        public Form2(Form1 parent, string category, string difficulty, int duration, string imageSet)
        {
            InitializeComponent();
            parentForm = parent;
            selectedCategory = category;
            selectedDifficulty = difficulty;
            gameDuration = duration;
            selectedImageSet = imageSet;
        }

        public string SelectedDifficulty { get; set; }
        public string SelectedImageType { get; set; }
        public string SelectedCategory { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 second
            timeLeft = gameDuration;
            lblTimer.Text = $"Time Left: {timeLeft} seconds";
            lblCategory.Text = $"Kategori: {selectedCategory}";
            lblDifficulty.Text = $"Seviye: {selectedDifficulty}";

            pictureBoxHangman.Image = Image.FromFile($"{selectedImageSet}0.jpg");

            txtGuess.KeyDown += TxtGuess_KeyDown;

            var words = wordList[selectedCategory]
                .Where(w => w.Difficulty.Equals(selectedDifficulty, StringComparison.OrdinalIgnoreCase))
                .ToList();
            Random random = new Random();
            var selected = words[random.Next(words.Count)];
            selectedWord = selected.Word.ToUpper();
            displayedWord = new string('_', selectedWord.Length);

            lblClue.Text = $"İpucu: {selected.Clue}";
            lblWord.Text = string.Join(" ", displayedWord.ToCharArray());
            lblWordLength.Text = $"Kelime Uzunluğu: {selectedWord.Length}";
            lblPoints.Text = $"Puan: {points}";
            lblIncorrectLetters.Text = "Hatalı Harfler: ";

            timer1.Start();
        }

        private void TxtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuess_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private List<char> allGuessedLetters = new List<char>();
        private void btnGuess_Click(object sender, EventArgs e)
        {
            string input = txtGuess.Text.ToUpper();
            if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
            {
                MessageBox.Show("Please enter a single letter.");
                txtGuess.Clear();
                return;
            }

            char guessedLetter = input[0];
            if (allGuessedLetters.Contains(guessedLetter))
            {
                MessageBox.Show("You have already guessed this letter.");
                txtGuess.Clear();
                return;
            }

            allGuessedLetters.Add(guessedLetter);

            if (selectedWord.Contains(guessedLetter))
            {
                var updatedWord = displayedWord.ToCharArray();
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (selectedWord[i] == guessedLetter)
                    {
                        updatedWord[i] = guessedLetter;
                    }
                }
                displayedWord = new string(updatedWord);
                lblWord.Text = string.Join(" ", displayedWord.ToCharArray());

                if (!displayedWord.Contains('_'))
                {
                    timer1.Stop();
                    this.BackColor = Color.Green;
                    MessageBox.Show("Congratulations! You won!");
                    this.Tag = "WinGame";
                    this.Close();
                }
            }
            else if(incorrectLetters.Contains(guessedLetter))
            {
                MessageBox.Show("You have already guessed this letter.");
                txtGuess.Clear();
                return;
            }
            else if(!char.IsLetter(guessedLetter))
            {
                MessageBox.Show("Please enter a valid letter.");
                txtGuess.Clear();
                return;
            }
            else
            {
                incorrectGuesses++;
                points -= 10;
                incorrectLetters.Add(guessedLetter);

                lblPoints.Text = $"Points: {points}";
                lblIncorrectLetters.Text = $"Incorrect Letters: {string.Join(", ", incorrectLetters)}";
                pictureBoxHangman.Image = Image.FromFile($"{selectedImageSet}{incorrectGuesses}.jpg");

                if (incorrectGuesses == 10)
                {
                    timer1.Stop();
                    this.BackColor = Color.Red;
                    MessageBox.Show($"You lost! The word was: {selectedWord}");
                    this.Close();
                }
            }

            txtGuess.Clear();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to end the game?", "End Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You are leaving the game.");
                this.Tag = "EndGame"; 
                this.Close();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag?.ToString() != "EndGame")
            {
                timer1.Stop();
                parentForm.Show();
            }
        }
        private void Form2_Leave(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = $"Time Left: {timeLeft} seconds";
            if (timeLeft == 0)
            {
                timer1.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show($"Time's up! You lost! The word was: {selectedWord}");
                this.Tag = "TimeUp";
                this.Close();
            }
            else if (this.Tag?.ToString() == "EndGame" || this.Tag?.ToString() == "WinGame")
            {
                timer1.Stop();
            }

        }

        private void lblIncorrectLetters_Click(object sender, EventArgs e)
        {

        }

        private void lblWord_Click(object sender, EventArgs e)
        {

        }
    }
}
