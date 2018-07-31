using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomControlSample.ViewModels
{
    public class DetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
            => this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private bool _IsEditable;
        public bool IsEditable
        {
            get => this._IsEditable;
            set
            {
                if (this._IsEditable == value)
                    return;
                this._IsEditable = value;
                this.RaisePropertyChanged();
            }
        }

        private string _Text;
        public string Text
        {
            get => this._Text;
            set
            {
                if (this._Text == value)
                    return;
                this._Text = value;
                this.RaisePropertyChanged();
            }
        }
    }
}
