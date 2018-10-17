using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFood
{
  public  class TraySchedule
    {
        public Tray tray { get; set; }
        public Schedule schedule { get; set; }

        public List<TrayItem> trayItem { get; set; }

        public TraySchedule()
        {
            //tray = new Tray();
            //schedule = new Schedule();
        }
    }
}
