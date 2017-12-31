using Microsoft.Win32;
using Projekt_ConsoleGameApp;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Xml.Linq;

namespace Projekt_WPF_Anwendung.ViewModel
{
    public class MainWindowViewModel : ObservableObject
    {
        #region ViewModel

        private ObservableCollection<Game> _spiele;
        public ObservableCollection<Game> Spiele
        {
            get { return _spiele; }
            set { OnPropertyChanged(ref _spiele, value); }
        }

        private Game _selectedSpiel;
        public Game SelectedSpiel
        {
            get { return _selectedSpiel; }
            set
            {
                OnPropertyChanged(ref _selectedSpiel, value);
                if(_selectedSpiel != null)
                {
                    Monster = new ObservableCollection<Monster>(_selectedSpiel.MonsterListe);
                    Spieler = new ObservableCollection<Player>(_selectedSpiel.PlayerListe.Get_All_Players());
                }
                SelectedIndexSpieler = 0;
            }
        }

        private ObservableCollection<Monster> _monster;
        public ObservableCollection<Monster> Monster
        {
            get { return _monster; }
            set { OnPropertyChanged(ref _monster, value); }
        }

        private ObservableCollection<Player> _spieler;
        public ObservableCollection<Player> Spieler
        {
            get { return _spieler; }
            set { OnPropertyChanged(ref _spieler, value); }
        }

        private Player _selectedSpieler;
        public Player SelectedSpieler
        {
            get { return _selectedSpieler; }
            set
            {
                OnPropertyChanged(ref _selectedSpieler, value);
                if( _selectedSpieler != null)
                    Helden = new ObservableCollection<Hero>(_selectedSpieler.Heroes);
            }
        }

        private ObservableCollection<Hero> _helden;
        public ObservableCollection<Hero> Helden
        {
            get { return _helden; }
            set { OnPropertyChanged(ref _helden, value); }
        }

        private int _selectedIndexSpiel;
        public int SelectedIndexSpiel
        {
            get { return _selectedIndexSpiel; }
            set { OnPropertyChanged(ref _selectedIndexSpiel, value); }
        }

        private int _selectedIndexSpieler;
        public int SelectedIndexSpieler
        {
            get { return _selectedIndexSpieler; }
            set { OnPropertyChanged(ref _selectedIndexSpieler, value); }
        }

        #endregion

        #region Commands

        public ICommand OpenCommand { get; }

        /// <summary>
        /// Ein OpenFileDialog wird geöffnent und man soll ein XML File auswählen.
        /// </summary>
        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "XML File|*.xml",
                Title = "XML File auswählen",
            };
            if (openFileDialog.ShowDialog() == true)
            {
                Spiele = new ObservableCollection<Game>(DataGenerator.Read_XML_Tree_Games(XElement.Load(openFileDialog.FileName)));
                SelectedIndexSpiel = 0;
            }
        }

        #endregion

        /// <summary>
        /// Konstruktor vom MainWindowViewModel
        /// </summary>
        public MainWindowViewModel()
        {
            OpenCommand = new RelayCommand(OpenFile);
        }
    }
}
