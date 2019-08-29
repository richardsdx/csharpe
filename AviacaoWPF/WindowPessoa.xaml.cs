using Aviacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AviacaoWPF
{
    /// <summary>
    /// Lógica interna para WindowPessoa.xaml
    /// </summary>
    public partial class WindowPessoa : Window
    {
        public ViewModel.PessoasViewModel PessoasViewModel { get; set; }
        public WindowPessoa()
        {
            InitializeComponent();
            this.PessoasViewModel = new ViewModel.PessoasViewModel();
            this.DataContext = this;
        }

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Salvar();
            this.Close();
        }

        private void Cancelar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Adicionar_Button_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Adicionar();
        }

        private void Remover_Button_Click(object sender, RoutedEventArgs e)
        {
            this.PessoasViewModel.Remover();
        }
    }
}
