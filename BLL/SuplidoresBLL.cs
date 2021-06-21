using Pedidos.DAL;
using Pedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pedidos.BLL
{
    public class SuplidoresBLL
    {
        public static List<Suplidores> GetList(Expression<Func<Suplidores, bool>> suplidores)
        {
            Contexto contexto = new Contexto();
            List<Suplidores> Lista = new List<Suplidores>();

            try
            {
                Lista = contexto.Suplidores.Where(suplidores).ToList(); 
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Lista;
        }
    }
}
