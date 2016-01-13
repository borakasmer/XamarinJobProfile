using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class LibraryManager
    {
        private readonly Library[] libraries;

        private int lastIndex;
        int currentIndex = 0;
        public LibraryManager()
        {
            libraries = InitData();
            lastIndex = libraries.Length - 1;
        }

        private Library[] InitData()
        {
            var initData = new Library[] {
                new Library() {
                    Title="Android for .Net Developers",
                    Description="Provides an overview of the tools uses in Android"+
                    "development process including the newly relased Android Studio.",
                    Image="adam"
                },
                new Library()
                {
                    Title="Android Dreams, Widget, Notifications",
                    Description="Provide users with a rich and interactive experiance "+
                    "without ever requiring them to open your app.",
                    Image="Hubbard"
                },
                new Library() {
                    Title="Android Phptp/Video Programming",
                    Description="Learn How to capitalize on the Android camera "+
                    "within your apps to capture still photos and video.",
                    Image="Messi"
                },
                new Library() {
                    Title="Android Location-Based Apps",
                    Description="Cove the wide range of Android location capabilities "+
                    "including determining user location, power managment, and"+
                    "translating location to human-readble addresses",
                    Image="Nathan"
                }
            };
            return initData;
        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev() { if (currentIndex > 0) { --currentIndex; } }
        public void MoveNext() { if (currentIndex < libraries.Length - 1) { ++currentIndex; } }

        public Library Current
        {
            get { return libraries[currentIndex]; }
        }

        public bool CanMovePrev
        {
            get { return currentIndex > 0; }
        }
        public bool CanMoveNext
        {
            get { return currentIndex < lastIndex; }
        }
    }
}
