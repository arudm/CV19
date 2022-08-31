using CV19.ViewModels.Base;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        /// <summary>Заголовок окна</summary>
        #region Заголовок окна
        private string _Title = "Анализ статистики CV19";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        } 
        #endregion
    }
}
