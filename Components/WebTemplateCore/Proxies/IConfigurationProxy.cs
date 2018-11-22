namespace GoC.WebTemplate.Components.Proxies
{
    public interface IConfigurationProxy
    {
        string CustomSearch { get; }
        string SignOutLinkURL { get; }
        string SignInLinkURL { get; }
        ISessionTimeOutElementProxy SessionTimeOut { get;  }
        ILeavingSecureSiteWarningElementProxy LeavingSecureSiteWarning { get;  }

        /// <summary>
        /// version
        /// </summary>
        string Version { get;  }

        /// <summary>
        /// theme
        /// </summary>
        string Theme { get;  }


        /// <summary>
        /// cdts environment to use
        /// </summary>
        string Environment { get;  }

        /// <summary>
        /// LoadJQueryFromGoogle
        /// </summary>
        bool LoadJQueryFromGoogle { get;  }

        /// <summary>
        /// ShowPreContent
        /// </summary>
        bool ShowPreContent { get;  }

        /// <summary>
        /// ShowPostContent
        /// </summary>
        bool ShowPostContent { get;  }

        /// <summary>
        /// ShowFeedbackLink
        /// </summary>
        bool ShowFeedbackLink { get;  }

        /// <summary>
        /// URL used to redirect users when they click the feedback link
        /// </summary>
        string FeedbackLinkurl { get;  }

        /// <summary>
        /// ShowSearch
        /// </summary>
        bool ShowShearch { get;  }

        /// <summary>
        /// ShowSharePageLink
        /// </summary>
        bool ShowSharePageLink { get;  }

        /// <summary>
        /// ShowLanguageLink
        /// </summary>
        bool ShowLanguageLink { get; }
        
        /// <summary>
        /// StaticFilesLocation
        /// </summary>
        string StaticFilesLocation { get;  }

        bool? UseHttps { get; }
        string CustomSiteMenuURL { get; }
    }
}