namespace Models.Base
{
	public abstract class Entity : object
	{
		public Entity() : base()
		{
			Id = System.Guid.NewGuid();
			InsertDateTime = Utility.Now;
		}

		// **********
		[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
			(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
		public System.Guid Id { get; set; }
		// **********

		public System.DateTime InsertDateTime { get; set; }
	}
}