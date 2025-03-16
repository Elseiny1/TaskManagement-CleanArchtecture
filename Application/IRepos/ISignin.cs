using Core.ViewModels;

namespace Core.IRepos
{
    public interface ISignin
    {
        Task<AuthModel> SignInAsync(SignInVM model);
    }
}
