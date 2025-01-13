using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MyFirstWPFApp.Models
{
    // ObservableObject : CommunityToolkit.Mvvm 라이브러리에 속한 추상 클래스. Model에 선언된 변수들의 변화 체크
    internal class Person : ObservableObject
    {
        private int _id;
        public int Id { get { return _id; } set { SetProperty(ref _id, value); } }

        public string? _name;
        public string? Name { get { return _name; } set { SetProperty(ref _name, value); } }

        private bool _gender;
        public bool Gender { get { return _gender; } set { SetProperty(ref _gender, value); } }
    }
}
