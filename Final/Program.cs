using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    
    
        public partial class Form1 : Form
        {
            private int poprawneOdpowiedzi = 0;
            private int aktualnePytanie = -1;

            // Pytania i odpowiedzi
            private readonly string[] pytania = new string[]
            {
            "Co jest zawsze przed tobą, ale nigdy nie możesz tego zobaczyć?",
            "Co ma wiele kluczy, ale nie otwiera żadnych drzwi?",
            "Co jest tak delikatne, że nawet słowo może to złamać?",
            "Co jest większe niż Bóg, gorsze niż diabeł, bogaci to mają, biedni tego potrzebują, a jeśli to zjesz, umrzesz?"
            };

            private readonly string[,] odpowiedzi = new string[,]
            {
            { "Powietrze", "Cień", "Przyszłość", "Horyzont" },
            { "Fortepian", "Taran", "Wytrych", "Woźny" },
            { "Serce", "Lód", "Szkło", "Cisza" },
            { "Śmierć", "Czas", "Nic", "Nieskończoność" }
            };

            // Indeksy poprawnych odpowiedzi (0-based: que3, que1, que4, que3)
            private readonly int[] poprawne = new int[] { 2, 0, 3, 2 };

            public Form1()
            {
                InitializeComponent();
                wstep.Text = "Drzwi grobowca z wolna ustępują pod Twoim naciskiem, skrzypiąc jak kości starożytnego strażnika. Powietrze jest gęste od pyłu i woni zbutwiałych tkanin – to miejsce nie widziało żywego oddechu od stuleci. Pochodnia w Twojej dłoni rzuca niespokojne blaski, a cienie na ścianach zdają się drżeć wbrew prawom fizyki. Nagle, kilka kroków przed Tobą, mrok się rozstępuje..." +
                    "\r\n\r\n► Przed Tobą stoi Sfinks.\r\n\r\nJego kamienne ciało, pokryte pęknięciami czasu, zdaje się żyć w migotliwym świetle płomienia. Oczy – głębokie jak studnie prowadzące do podziemi – wpatrują się w Ciebie z nieludzką cierpliwością. Kiedy otwierasz usta, by przemówić, wargi Sfinksa poruszają się pierwsze, a głos rozlega się nie w uszach, lecz głęboko we wnętrzu Twojej czaszki:" +
                    "\r\n\r\n\"Witaj, śmiertelniku. Czy jesteś gotów stanąć przed Sędzią Zagubionych Dusz?\"";
                wstep.SelectionStart = 0;
                wstep.SelectionLength = 0;

                smierc.Click += Click_Button;
                uciekaj.Click += Click_Button;
                wysluchaj.Click += Click_Button;
                pytanie.Click += Click_Button;

                que1.Click += Odpowiedz_Click;
                que2.Click += Odpowiedz_Click;
                que3.Click += Odpowiedz_Click;
                que4.Click += Odpowiedz_Click;
            }

            private void PokazPytanie()
            {
                // Losuj pytanie, nie powtarzaj tego samego dwa razy z rzędu
                Random rnd = new Random();
                int nowePytanie;
                do
                {
                    nowePytanie = rnd.Next(pytania.Length);
                } while (nowePytanie == aktualnePytanie);
                aktualnePytanie = nowePytanie;

                blokpytanie.Visible = true;
                que1.Visible = true;
                que2.Visible = true;
                que3.Visible = true;
                que4.Visible = true;
                pytanie.Visible = false;
                wstep.Visible = false;
                tytul.Visible = false;

                blokpytanie.Text = pytania[aktualnePytanie];
                que1.Text = odpowiedzi[aktualnePytanie, 0];
                que2.Text = odpowiedzi[aktualnePytanie, 1];
                que3.Text = odpowiedzi[aktualnePytanie, 2];
                que4.Text = odpowiedzi[aktualnePytanie, 3];
            }

            private void Odpowiedz_Click(object sender, EventArgs e)
            {
                Button btn = sender as Button;
                int idx = -1;
                if (btn == que1) idx = 0;
                else if (btn == que2) idx = 1;
                else if (btn == que3) idx = 2;
                else if (btn == que4) idx = 3;

                if (idx == poprawne[aktualnePytanie])
                {
                    poprawneOdpowiedzi++;
                    if (poprawneOdpowiedzi >= 3)
                    {
                        Koniec();
                    }
                    else
                    {
                        PokazPytanie();
                    }
                }
                else
                {
                    SmiercAkcja();
                }
            }

            private void UciekajAkcja()
            {
                wstep.SelectionStart = 0;
                wstep.SelectionLength = 0;
                wstep.Text = "Uciekasz w popłochu, serce bije jak młot. Cienie za Tobą zdają się gonić, a echo Twoich kroków odbija się od kamiennych ścian. W końcu, po długim biegu, znajdujesz się na zewnątrz grobowca, oddychając ciężko i czując ulgę. Ale wiesz, że Sfinks nadal czeka w mroku, gotów na kolejną próbę." +
                    "\r\n\r\n► Uciekłeś przed Sfinksem.";
                smierc.Visible = false;
                uciekaj.Visible = false;
                wysluchaj.Visible = false;
                ponownie.Visible = true;
                poddaj.Visible = true;
                poddaj.Click += (s, e) => { Application.Exit(); };
                ponownie.Click += (s, e) => { Application.Restart(); };
            }

            private void SmiercAkcja()
            {
                wstep.SelectionStart = 0;
                wstep.SelectionLength = 0;
            wstep.Text = "Kamienne oczy posągu śledzą twój każdy ruch, a powietrze wokół gęstnieje, jakby samo miejsce sprzeciwiało się twojej zuchwałości. " +
                    "Nagle - ostry ból rozdziera Twoją czaszkę, jakby ktoś wbił ci w skronie rozżarzone sztylety. Kolana uginają się pod tobą, a z ust wydobywa się chrapliwy jęk." +
                    "\r\n\r\nWidzenie przesłania ci krwawą mgłą." +
                    "\r\n\r\nW ostatnim przebłysku świadomości dostrzegasz, jak kamienne powieki Sfinksa drgają, a jego źrenice – głębokie jak przepaść – zwracają się ku tobie z nieludzką, zimną ciekawością. Czujesz, jak coś wysysa z ciebie życie, powoli, metodycznie, jak gdybyś był tylko kolejną świecą, którą można zdmuchnąć." +
                    "\r\n\r\nPróbujesz pełznąć dalej, ale twoje ciało nie słucha rozkazów. Palce drgawkowo zaciskają się na kamiennej posadzce, zostawiając krwawe ślady. Ostatnie, co widzisz, to uśmiech Sfinksa – ledwie dostrzegalny, a jednak niewyobrażalnie pełen głodu." +
                    "\r\n\r\nŚwiat gaśnie.";
                smierc.Visible = false;
                uciekaj.Visible = false;
                wysluchaj.Visible = false;
                ponownie.Visible = true;
                poddaj.Visible = true;
                poddaj.Click += (s, e) => { Application.Exit(); };
                ponownie.Click += (s, e) => { Application.Restart(); };
            }

            private void WysluchajAkcja()
            {
                wstep.SelectionStart = 0;
                wstep.SelectionLength = 0;
                wstep.Text = "Sfinks milczy przez chwilę, a jego oczy zdają się przenikać przez Twoją duszę. W końcu, głos rozbrzmiewa ponownie, głęboki i pełen mocy:" +
                    "\r\n\r\n\"Twoja odwaga jest godna podziwu, sprawdźmy czy twój umysł jej dorównuje, czy jesteś gotów odpowiedzieć na moje pytania?\"";
                smierc.Visible = false;
                uciekaj.Visible = true;
                wysluchaj.Visible = false;
                pytanie.Visible = true;
                pytanie.Text = "Zadaj pytanie";
            }

            private void Koniec()
            {
                wstep.SelectionStart = 0;
                wstep.SelectionLength = 0;
                wstep.Visible = true;
                wstep.Text = "Twoje odpowiedzi były poprawne, Sfinks skinął głową, a jego kamienne usta rozciągnęły się w uśmiechu" +
                    "Kamienne łąpy Sfinxa rozsuwają się i ujawniają przed tobą niewielką obsydianową skrzynkę ze złotymi zdobieniami, zdobyłeś to po co przyszedłeś";
                blokpytanie.Visible = false;
                que1.Visible = false;
                que2.Visible = false;
                que3.Visible = false;
                que4.Visible = false;
                smierc.Visible = false;
                uciekaj.Visible = false;
                wysluchaj.Visible = false;
                ponownie.Visible = true;
                ponownie.Text = "Zagraj ponownie";
                poddaj.Visible = false;
                poddaj.Text = "Zakończ grę";
                poddaj.Click += (s, e) => { Application.Exit(); };
                ponownie.Click += (s, e) => { Application.Restart(); };
            }

            private void Click_Button(object sender, EventArgs e)
            {
                Button klikniety = sender as Button;
                switch (klikniety.Name)
                {
                    case "smierc":
                        SmiercAkcja();
                        break;
                    case "uciekaj":
                        UciekajAkcja();
                        break;
                    case "wysluchaj":
                        WysluchajAkcja();
                        break;
                    case "pytanie":
                        poprawneOdpowiedzi = 0;
                        PokazPytanie();
                        break;
                    default:
                        break;
                }
            }
        }
    }



