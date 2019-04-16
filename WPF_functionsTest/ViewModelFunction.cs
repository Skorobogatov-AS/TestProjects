using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_functionsTest.ViewModels
{
    class ViewModelFunction
    {
        public ObservableCollection<ModelFunction> Collection { get; set; }

        public ViewModelFunction()
        {
            Collection = new ObservableCollection<ModelFunction>();
            Collection.Add(new ModelFunction("Линейная", 1));
            Collection.Add(new ModelFunction("Квадратичная", 2));
            Collection.Add(new ModelFunction("Кубическая", 3));
            Collection.Add(new ModelFunction("4-ой степени", 4));
            Collection.Add(new ModelFunction("5-ой степени", 5));
        }
    }
}
