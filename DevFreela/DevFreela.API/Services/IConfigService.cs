namespace DevFreela.API.Services
{
    public interface IConfigService
    {
        int GetValue();

        public class COnfigService : IConfigService
        {
            private int _value;
            public int GetValue()
            {
                _value++;
                return _value;
            }
        }
    }
}
