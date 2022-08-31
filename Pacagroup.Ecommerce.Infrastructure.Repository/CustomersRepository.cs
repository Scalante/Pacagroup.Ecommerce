using Pacagroup.Ecommerce.Domain.Entity;
using Pacagroup.Ecommerce.Infrastructure.Interface;
using Pacagroup.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Infrastructure.Repository
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomersRepository(IConnectionFactory connectionFactory)
        {
            this._connectionFactory = connectionFactory;
        }

       
        #region Métodos Síncronos

        public bool Insert(Customers customers)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customers Get(string customerId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string customerId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customers customers)
        {
            throw new NotImplementedException();
        }

        #endregion



        #region Métodos Asíncronos




        public Task<IEnumerable<Customers>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customers> GetAsync(string customerId)
        {
            throw new NotImplementedException();
        }



        public Task<bool> InsertAsync(Customers customers)
        {
            throw new NotImplementedException();
        }



        public Task<bool> UpdateAsync(Customers customers)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}