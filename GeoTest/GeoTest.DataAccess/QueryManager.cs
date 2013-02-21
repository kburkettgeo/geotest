using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTest.DataAccess
{
    public static class QueryManager
    {
        public static IEnumerable<GitMessage> GetAllMessages()
        {
            var retval = new List<GitMessage>();
            var entities = new GitTestEntities();
            var dbMessages = entities.Messages;

            foreach (var dbMessage in dbMessages)
            {
                retval.Add(new GitMessage {Id = dbMessage.Id, Message = dbMessage.Message1});
            }

            return retval;
        }
    }
}
