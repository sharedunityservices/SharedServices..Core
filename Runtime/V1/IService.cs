namespace SharedServices.V1
{
    public interface IService
    {
        virtual int Priority => 0;
        void Initialize() { }
    }
}