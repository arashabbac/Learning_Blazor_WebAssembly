using Data.Repositories;

namespace Data
{
	public class UnitOfWork : Base.UnitOfWork, IUnitOfWork
	{
		//public UnitOfWork() : base()
		//{
		//}

		public UnitOfWork(Tools.Options options) : base(options)
		{
		}

        // **************************************************
        //private IXXXXXRepository _xXXXXRepository;

        //public IXXXXXRepository XXXXXRepository
        //{
        //	get
        //	{
        //		if (_xXXXXRepository == null)
        //		{
        //			_xXXXXRepository =
        //				new XXXXXRepository(DatabaseContext);
        //		}

        //		return _xXXXXRepository;
        //	}
        //}
        // **************************************************

        #region UserRepository
        private IUserRepository _userRepository;

		public IUserRepository UserRepository
		{
			get
			{
				if (_userRepository == null)
				{
					_userRepository =
						new UserRepository(DatabaseContext);
				}

				return _userRepository;
			}
		}
        #endregion /UserRepository
    }
}
