using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Web.Mvc;

namespace AnjaliMISDAL
{
    public interface IUnitOfWork : IDisposable        
    {
        /// <summary>
        /// Commit all changes made in a container.
        /// </summary>
        void Commit();

        /// <summary>
        ///  If the entity have fixed properties and any optimistic concurrency problem exists,
        ///  then 'client changes' are refreshed - Client wins
        /// </summary>
        void CommitAndRefreshChanges();

        /// <summary>
        /// Rollback tracked changes. See references of UnitOfWork pattern
        /// </summary>
        void RollbackChanges();

        /// <summary>
        /// Execute specific query with underliying persistence store
        /// </summary>
        /// <typeparam name="T">Entity type to map query results</typeparam>
        /// <example>
        /// SELECT idCustomer,Name FROM dbo.[Customers] WHERE idCustomer > {0}
        /// </example>
        /// <param name="sqlQuery"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<T> ExecuteQuery<T>(string sqlQuery, params object[] parameters);

        /// <summary>
        /// Execute arbitrary command into underliying persistence store
        /// </summary>
        /// <param name="sqlCommand">
        /// Command to execute
        /// <example>
        /// SELECT idCustomer,Name FROM dbo.[Customers] WHERE idCustomer > {0}
        /// </example>
        ///</param>
        /// <param name="parameters">A vector of parameters values</param>
        /// <returns>The number of affected records</returns>
        int ExecuteCommand(string sqlCommand, params object[] parameters);
    }

}
