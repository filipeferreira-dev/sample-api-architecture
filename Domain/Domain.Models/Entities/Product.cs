using System;

namespace Domain.Models.Entities
{
    public class Product
    {
        #region Properties

        public DateTime ExpirationDate { get; private set; }

        public string Name { get; private set; }

        public long ProductId { get; private set; }

        public Guid ProductUuid { get; private set; }

        #endregion

        #region Constructors

        public Product(string name, DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
            Name = name;
        }

        #endregion

        #region Methods

        public bool IsExpirated()
        {
            return ExpirationDate.Date < DateTime.Now.Date;
        }

        #endregion
    }
}
