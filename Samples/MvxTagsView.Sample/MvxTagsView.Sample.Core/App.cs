using MvvmCross.IoC;

namespace MvxTagsView_Sample.Core
{
    public class App : MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

			RegisterAppStart<ViewModels.FirstViewModel>();
        }
    }
}
