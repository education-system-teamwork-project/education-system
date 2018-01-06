namespace education.system.Services.Contracts
{
    using Models.Category;

    public interface ICategoryService : IService
    {
        bool Add(string name);

        CategoryBaseModel ById(int id);

        bool Exists(int id);

        void Edit(int id, string name);
    }
}
