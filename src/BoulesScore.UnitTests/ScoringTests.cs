//using Machine.Specifications;
//using BoulesScore.ViewModels;
//using Microsoft.Maui.Handlers;
//using Microsoft.Maui.Animations;

//namespace BoulesScore.UnitTests
//{
//    [Subject("Scoring")]
//    public class When_increasing_Right_score
//    {
//        static BoulesScore.ViewModels.MainPage? subject;

//        Establish context = () =>
//        {
//            // boilerplate
//            //var appBuilder = MauiApp.CreateBuilder()
//            //                    .UseMauiApp<MockApplication>();

//            //var mauiApp = appBuilder.Build();
//            //var application = mauiApp.Services.GetRequiredService<IApplication>();
//            //application.Handler = new ApplicationHandlerStub();
//            //application.Handler.SetMauiContext(new HandlersContextStub(mauiApp.Services));


//            subject = new ViewModels.MainPage();          
//        };


//        Because of = () =>
//            subject.UpdateCounterRight("1");

//        It should_increase_Right_by_one = () =>
//            subject.CounterRight.ShouldEqual(1);

//        It should_leave_Left_at_zero = () =>
//            subject.CounterLeft.ShouldEqual(0);
//    }



//    class MockApplication : Application
//    {
//        public new Application? Current = null;
//    }

//    // Inspired by https://github.com/dotnet/maui/blob/main/src/Controls/tests/Core.UnitTests/TestClasses/ApplicationHandlerStub.cs
//    class ApplicationHandlerStub : ElementHandler<IApplication, object>
//    {
//        public ApplicationHandlerStub() : base(Mapper)
//        {
//        }

//        public static IPropertyMapper<IApplication, ApplicationHandlerStub> Mapper = new PropertyMapper<IApplication, ApplicationHandlerStub>(ElementMapper);

//        protected override object CreatePlatformElement()
//        {
//            return new object();
//        }
//    }

//    class HandlersContextStub : IMauiContext
//    {
//        public HandlersContextStub(IServiceProvider services)
//        {
//            Services = services;
//            Handlers = Services.GetRequiredService<IMauiHandlersFactory>();
//            AnimationManager = services.GetService<IAnimationManager>() ?? throw new NullReferenceException();
//        }

//        public IServiceProvider Services { get; }

//        public IMauiHandlersFactory Handlers { get; }

//        public IAnimationManager AnimationManager { get; }
//    }
//}