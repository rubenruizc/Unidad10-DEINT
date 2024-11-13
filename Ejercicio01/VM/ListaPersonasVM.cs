using BL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.VM
{
    public class ListaPersonasVM : INotifyPropertyChanged
    {
        #region Atributos
        private clsPersona personaSeleccionada;
        #endregion

        public clsPersona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set
            {
                if (personaSeleccionada != value)
                {
                    personaSeleccionada = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<clsPersona> ListaPersonas { get; set; }

        public ListaPersonasVM()
        {
            ListaPersonas = new ObservableCollection<clsPersona>(ClsListadoBL.listadoPersonas());
        }

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

