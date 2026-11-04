using CommunityToolkit.Mvvm.Input;
using NotatkiMobilne.Models;

namespace NotatkiMobilne.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}