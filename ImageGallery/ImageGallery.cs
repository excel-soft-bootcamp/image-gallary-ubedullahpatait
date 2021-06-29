using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGallery
{
  public class ImageGallery
    {
        Isend _send;
        

             public  void Share(Isend send)
        {
            this._send = send;
            send.Send();

        }


    }
}
