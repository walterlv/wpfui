﻿// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wpf.Ui.Gallery.Services;
using Wpf.Ui.Gallery.Services.Contracts;
using Wpf.Ui.Gallery.ViewModels.Pages;
using Wpf.Ui.Gallery.ViewModels.Pages.BasicInput;
using Wpf.Ui.Gallery.ViewModels.Pages.DialogsAndFlyouts;
using Wpf.Ui.Gallery.ViewModels.Pages.Icons;
using Wpf.Ui.Gallery.ViewModels.Pages.Media;
using Wpf.Ui.Gallery.ViewModels.Pages.Navigation;
using Wpf.Ui.Gallery.ViewModels.Pages.StatusAndInfo;
using Wpf.Ui.Gallery.ViewModels.Pages.Text;
using Wpf.Ui.Gallery.ViewModels.Windows;
using Wpf.Ui.Gallery.Views;
using Wpf.Ui.Gallery.Views.Pages;
using Wpf.Ui.Gallery.Views.Pages.BasicInput;
using Wpf.Ui.Gallery.Views.Pages.DialogsAndFlyouts;
using Wpf.Ui.Gallery.Views.Pages.Icons;
using Wpf.Ui.Gallery.Views.Pages.Media;
using Wpf.Ui.Gallery.Views.Pages.Navigation;
using Wpf.Ui.Gallery.Views.Pages.StatusAndInfo;
using Wpf.Ui.Gallery.Views.Pages.Text;
using Wpf.Ui.Mvvm.Contracts;
using Wpf.Ui.Mvvm.Services;

namespace Wpf.Ui.Gallery;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    // The .NET Generic Host provides dependency injection, configuration, logging, and other services.
    // https://docs.microsoft.com/dotnet/core/extensions/generic-host
    // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
    // https://docs.microsoft.com/dotnet/core/extensions/configuration
    // https://docs.microsoft.com/dotnet/core/extensions/logging
    private static readonly IHost _host = Host
        .CreateDefaultBuilder()
        .ConfigureAppConfiguration(c => { c.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)); })
        .ConfigureServices((context, services) =>
        {
            // App Host
            services.AddHostedService<ApplicationHostService>();

            // Main window container with navigation
            services.AddScoped<IWindow, ContainerWindow>();
            services.AddScoped<ContainerViewModel>();
            services.AddScoped<INavigationService, NavigationService>();
            services.AddScoped<ISnackbarService, SnackbarService>();
            services.AddScoped<IDialogService, DialogService>();

            // Top-level pages
            services.AddTransient<DashboardPage>();
            services.AddTransient<DashboardViewModel>();
            services.AddTransient<AllControlsPage>();
            services.AddTransient<AllControlsViewModel>();
            services.AddTransient<SettingsPage>();
            services.AddTransient<SettingsViewModel>();

            // Basic Input
            services.AddTransient<BasicInputPage>();
            services.AddTransient<BasicInputViewModel>();
            services.AddTransient<AnchorPage>();
            services.AddTransient<AnchorViewModel>();
            services.AddTransient<ButtonPage>();
            services.AddTransient<ButtonViewModel>();
            services.AddTransient<HyperlinkPage>();
            services.AddTransient<HyperlinkViewModel>();
            services.AddTransient<ToggleButtonPage>();
            services.AddTransient<ToggleButtonViewModel>();
            services.AddTransient<ToggleSwitchPage>();
            services.AddTransient<ToggleSwitchViewModel>();
            services.AddTransient<CheckBoxPage>();
            services.AddTransient<CheckBoxViewModel>();
            services.AddTransient<ComboBoxPage>();
            services.AddTransient<ComboBoxViewModel>();
            services.AddTransient<RadioButtonPage>();
            services.AddTransient<RadioButtonViewModel>();
            services.AddTransient<RatingPage>();
            services.AddTransient<RatingViewModel>();
            services.AddTransient<ThumbRatePage>();
            services.AddTransient<ThumbRateViewModel>();
            services.AddTransient<SliderPage>();
            services.AddTransient<SliderViewModel>();

            // Dialogs and Flyouts
            services.AddTransient<DialogsAndFlyoutsPage>();
            services.AddTransient<DialogsAndFlyoutsViewModel>();
            services.AddTransient<SnackbarPage>();
            services.AddTransient<SnackbarViewModel>();
            services.AddTransient<DialogPage>();
            services.AddTransient<DialogViewModel>();
            services.AddTransient<FlyoutPage>();
            services.AddTransient<FlyoutViewModel>();
            services.AddTransient<MessageBoxPage>();
            services.AddTransient<MessageBoxViewModel>();

            // Web View
            services.AddTransient<MediaPage>();
            services.AddTransient<MediaViewModel>();
            services.AddTransient<WebViewPage>();
            services.AddTransient<WebViewViewModel>();

            // Navigation
            services.AddTransient<NavigationPage>();
            services.AddTransient<NavigationViewModel>();
            services.AddTransient<NavigationViewPage>();
            services.AddTransient<NavigationViewViewModel>();
            services.AddTransient<TabControlPage>();
            services.AddTransient<TabControlViewModel>();

            // Status and Info
            services.AddTransient<StatusAndInfoPage>();
            services.AddTransient<StatusAndInfoViewModel>();
            services.AddTransient<InfoBarPage>();
            services.AddTransient<InfoBarViewModel>();
            services.AddTransient<ProgressBarPage>();
            services.AddTransient<ProgressBarViewModel>();
            services.AddTransient<ProgressRingPage>();
            services.AddTransient<ProgressRingViewModel>();
            services.AddTransient<ToolTipPage>();
            services.AddTransient<ToolTipViewModel>();

            // Text
            services.AddTransient<TextPage>();
            services.AddTransient<TextViewModel>();
            services.AddTransient<AutoSuggestBoxPage>();
            services.AddTransient<AutoSuggestBoxViewModel>();
            services.AddTransient<NumberBoxPage>();
            services.AddTransient<NumberBoxViewModel>();
            services.AddTransient<PasswordBoxPage>();
            services.AddTransient<PasswordBoxViewModel>();
            services.AddTransient<RichTextBoxPage>();
            services.AddTransient<RichTextBoxViewModel>();
            services.AddTransient<LabelPage>();
            services.AddTransient<LabelViewModel>();
            services.AddTransient<TextBlockPage>();
            services.AddTransient<TextBlockViewModel>();
            services.AddTransient<TextBoxPage>();
            services.AddTransient<TextBoxViewModel>();

            // Icons
            services.AddTransient<IconsPage>();
            services.AddTransient<IconsViewModel>();
            services.AddTransient<SymbolIconPage>();
            services.AddTransient<SymbolIconViewModel>();
            services.AddTransient<FontIconPage>();
            services.AddTransient<FontIconViewModel>();
        }).Build();

    /// <summary>
    /// Gets registered service.
    /// </summary>
    /// <typeparam name="T">Type of the service to get.</typeparam>
    /// <returns>Instance of the service or <see langword="null"/>.</returns>
    public static T? GetService<T>()
        where T : class
    {
        return _host.Services.GetService(typeof(T)) as T ?? null;
    }

    /// <summary>
    /// Occurs when the application is loading.
    /// </summary>
    private async void OnStartup(object sender, StartupEventArgs e)
    {
        await _host.StartAsync();
    }

    /// <summary>
    /// Occurs when the application is closing.
    /// </summary>
    private async void OnExit(object sender, ExitEventArgs e)
    {
        await _host.StopAsync();

        _host.Dispose();
    }

    /// <summary>
    /// Occurs when an exception is thrown by an application but not handled.
    /// </summary>
    private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        // For more info see https://docs.microsoft.com/en-us/dotnet/api/system.windows.application.dispatcherunhandledexception?view=windowsdesktop-6.0
    }
}
