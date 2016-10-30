﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using Awesomium.Core;
using ProjectMarkdown.Annotations;

namespace ProjectMarkdown.Model
{
    public class DocumentModel : INotifyPropertyChanged
    {
        public DocumentMetadata Metadata
        {
            get { return _metadata; }
            set
            {
                if (Equals(value, _metadata)) return;
                _metadata = value;
                OnPropertyChanged(nameof(Metadata));
            }
        }

        public DocumentMarkdown Markdown
        {
            get { return _markdown; }
            set
            {
                if (Equals(value, _markdown)) return;
                _markdown = value;
                OnPropertyChanged(nameof(Markdown));
            }
        }

        public DocumentHtml Html
        {
            get { return _html; }
            set
            {
                if (Equals(value, _html)) return;
                _html = value;
                OnPropertyChanged(nameof(Html));
            }
        }

        
        private DocumentMetadata _metadata;
        private DocumentMarkdown _markdown;
        private DocumentHtml _html;


        public event PropertyChangedEventHandler PropertyChanged;

        public DocumentModel(string documentName)
        {
            Metadata = new DocumentMetadata(documentName);
            Markdown = new DocumentMarkdown("");
            Html = new DocumentHtml("".ToUri());
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}