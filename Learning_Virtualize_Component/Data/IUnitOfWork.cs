namespace Data
{
	public interface IUnitOfWork : Base.IUnitOfWork
	{
        // **********
        Repositories.IUserRepository UserRepository { get; }
		// **********

	}
}
