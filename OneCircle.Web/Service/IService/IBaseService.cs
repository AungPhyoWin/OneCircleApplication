using OneCircle.Web.Models;


namespace OneCircle.Web.Service.IService
{
        public interface IBaseService
        {
            Task<ResponseDto?> SendAsync(RequestDto requestDto);
        }
}

