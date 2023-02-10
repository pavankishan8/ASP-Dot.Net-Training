using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransportApp.Data_Component
{
    public interface IRouteData
    {
        List<RouteTable> GetRouteTables();
        List<PickUpTable> GetPickUpTables(int routeNo);
        EmpTable GetEmp();
        void AddNewRoute(RouteTable routeName);
        void AddStops(List<PickUpTable> AllStops, string route);
        List<EmpRoute> GetEmpRoutes();

        List<EmpRoute> GetBillOfEmp(int empid);
        void AddNewBill(EmpRoute data);
    }

    public class RouteData : IRouteData
    {
        private readonly TransportEntities _context = new TransportEntities();

        public void AddNewBill(EmpRoute data)
        {
            _context.EmpRoutes.Add(data);
            _context.SaveChanges();
        }

        public List<EmpRoute> GetEmpRoutes() => _context.EmpRoutes.ToList();
        public EmpTable GetEmp()
        {
            throw new NotImplementedException();
        }

        public List<PickUpTable> GetPickUpTables(int routeNo)
        {
            List<PickUpTable> AllStops = new List<PickUpTable>();
            var AllData = _context.PickUpTables.ToList();
            foreach (var item in AllData)
            {
                if (item.RouteNo == routeNo)
                {
                    AllStops.Add(item);
                }
            }
            return AllStops;
        }

        public List<EmpRoute> GetBillOfEmp(int empid)
        {
            List<EmpRoute> tempdata = new List<EmpRoute>();
            foreach (var item in _context.EmpRoutes)
            {
                if (item.EmpID == empid)
                {
                    tempdata.Add(item);
                }
            }
            return tempdata;
        }

        public EmpTable GetEmployee(int id) => _context.EmpTables.FirstOrDefault((e) => e.EmpID == id);
        public List<RouteTable> GetRouteTables() => _context.RouteTables.ToList();

        public void AddNewRoute(RouteTable routeName)
        {
            _context.RouteTables.Add(routeName);
            _context.SaveChanges();
        }

        public List<EmpTable> getallemp() => _context.EmpTables.ToList();
        public void AddStops(List<PickUpTable> AllStops, string name)
        {
            int id = 0;
            foreach (var item in _context.RouteTables.ToList())
            {
                if (item.RouteName.Contains(name))
                {
                    id = item.RouteNo;
                }
            }
            if (id == 0)
            {
                throw new Exception("Route Data Is Not Updated");
            }
            foreach (var item in AllStops)
            {
                item.RouteNo = id;
                _context.PickUpTables.Add(item);
                _context.SaveChanges();
            }
            _context.SaveChanges();
        }
    }
}