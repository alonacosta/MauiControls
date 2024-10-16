using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class PhotoViewModel
    {
        public ObservableCollection<Photo> photos { get; private set; }
        public ObservableCollection<Photo> Photos
        {
            get { return photos; }  
            set { photos = value; } 
        }

        public PhotoViewModel() 
        {
            Photos = new ObservableCollection<Photo>()
            {
                new Photo() { Name="Andronema", ImageUrl="galaxy1.jpg"},
                new Photo() { Name="Milky way", ImageUrl="galaxy2.jpg"},
                new Photo() { Name="Universe", ImageUrl="galaxy3.jpg"},
                new Photo() { Name="Galaxy", ImageUrl="galaxy4.jpg"},
                new Photo() { Name="Sombrero", ImageUrl="galaxy5.jpg"},
                new Photo() { Name="Andronema", ImageUrl="galaxy1.jpg"},
                new Photo() { Name="Milky way", ImageUrl="galaxy2.jpg"},
                new Photo() { Name="Universe", ImageUrl="galaxy3.jpg"},
                new Photo() { Name="Galaxy", ImageUrl="galaxy4.jpg"},
                new Photo() { Name="Sombrero", ImageUrl="galaxy5.jpg"},
                new Photo() { Name="Milky way", ImageUrl="galaxy2.jpg"},
                new Photo() { Name="Universe", ImageUrl="galaxy3.jpg"},
                new Photo() { Name="Galaxy", ImageUrl="galaxy4.jpg"},
                new Photo() { Name="Sombrero", ImageUrl="galaxy5.jpg"},
            };
        }
    }
}
