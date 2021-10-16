using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App7.ViewModels
{
    public class JsonBase64 : BaseViewModel
    {
        string _nombre;
        string _appP;
        string _appM;
        string _correo;
        string _password;
        string _contador;
        string _nombreen;
        string _appPen;
        string _appMen;
        string _correoen;
        string _passworden;
        int _numero = 1;
        ICommand _encriclicomand;
        ICommand _desencriclicomand;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(NombreCompleto));

            }
        }
        public string AppP
        {
            get => _appP;
            set
            {
                if (string.Equals(_appP, value)) return;
                _appP = value;
                OnPropertyChanged(nameof(AppP));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        public string AppM
        {
            get => _appM;
            set
            {
                if (string.Equals(_appM, value)) return;
                _appM = value;
                OnPropertyChanged(nameof(AppM));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        public string Correo
        {
            get => _correo;
            set
            {
                if (string.Equals(_appM, value)) return;
                _correo = value;
                OnPropertyChanged(nameof(Correo));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        public string Pass
        {
            get => _password;
            set
            {
                if (string.Equals(_appM, value)) return;
                _password = value;
                OnPropertyChanged(nameof(Pass));
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        public string NombreCompleto => $"{Nombre} {AppP} {AppM} {Correo} {Pass}";


        public ICommand BotonEnc
        {
            get
            {
                if (_encriclicomand == null)
                    _encriclicomand = new Command(Encriptar);
                return _encriclicomand;

            }
        }
        public ICommand BotonDes
        {
            get
            {
                if (_desencriclicomand == null)
                    _desencriclicomand = new Command(Des);
                return _desencriclicomand;
            }
        }
        private void Encriptar()
        {
            if (_numero == 1)
            {
                _numero = 0;
                _nombreen = Base64EncryptService.Encriptar(_nombre);
                _appMen = Base64EncryptService.Encriptar(_appM);
                _appPen = Base64EncryptService.Encriptar(_appP);
                _correoen = Base64EncryptService.Encriptar(_correo);
                _passworden = Base64EncryptService.Encriptar(_password);
                ContConvertido = $"Nombre:{_nombreen}," +
                 $"Apellido Paterno:{_appPen}," + $"Apellido Materno:{_appMen}," +
                  $"Correo :{_correoen}," + $"Contraseña:{_passworden}";
            }
            else
            {
                _numero = 1;
                _nombreen = Base64EncryptService.Descriptar(_nombreen);
                _appMen = Base64EncryptService.Descriptar(_appMen);
                _appPen = Base64EncryptService.Descriptar(_appPen);
                _correoen = Base64EncryptService.Descriptar(_correoen);
                _passworden = Base64EncryptService.Descriptar(_passworden);
                ContConvertido = $"Nombre: {_nombreen}," +
                  $"Apellido Paterno: {_appPen}," + $"Apellido Materno: {_appMen}," +
                 $"Correo: {_correoen}," + $"Contraseña: {_passworden}";
            }
        }
        private void Des()
        {
            if (_numero == 1)
            {
                _numero = 0;
                _nombreen = Base64EncryptService.Encriptar(_nombre);
                _appMen = Base64EncryptService.Encriptar(_appM);
                _appPen = Base64EncryptService.Encriptar(_appP);
                _correoen = Base64EncryptService.Encriptar(_correo);
                _passworden = Base64EncryptService.Encriptar(_password);
                ContConvertido = $"Nombre:{_nombreen}," +
                 $"Apellido Paterno:{_appPen}," + $"Apellido Materno:{_appMen}," +
                  $"Correo :{_correoen}," + $"Contraseña:{_passworden}";
            }
            else
            {
                _numero = 1;
                _nombreen = Base64EncryptService.Descriptar(_nombreen);
                _appMen = Base64EncryptService.Descriptar(_appMen);
                _appPen = Base64EncryptService.Descriptar(_appPen);
                _correoen = Base64EncryptService.Descriptar(_correoen);
                _passworden = Base64EncryptService.Descriptar(_passworden);
                ContConvertido = $"Nombre: {_nombreen}," +
                  $"Apellido Paterno: {_appPen}," + $"Apellido Materno: {_appMen}," +
                 $"Correo: {_correoen}," + $"Contraseña: {_passworden}";
            }
        }

        public string ContConvertido
        {
            get => _contador;
            set
            {
                if (string.Equals(_contador, value)) return;
                _contador = value;
                OnPropertyChanged();
            }
        }
}
}
