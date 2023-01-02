﻿// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DontTouchKeyboard.UI;

internal class AppViewModelLocator
{
    public ShellViewModel Shell => Ioc.Default.GetService<ShellViewModel>();

    public SystemInfoViewModel Error => Ioc.Default.GetService<SystemInfoViewModel>();
}