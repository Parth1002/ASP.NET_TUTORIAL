﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("NewPublisherModel", "FK_Author_Book", "Author", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(NewPublisherModel.Author), "Book", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NewPublisherModel.Book), true)]

#endregion

namespace NewPublisherModel
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NewPublisherEntities2 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NewPublisherEntities2 object using the connection string found in the 'NewPublisherEntities2' section of the application configuration file.
        /// </summary>
        public NewPublisherEntities2() : base("name=NewPublisherEntities2", "NewPublisherEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NewPublisherEntities2 object.
        /// </summary>
        public NewPublisherEntities2(string connectionString) : base(connectionString, "NewPublisherEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NewPublisherEntities2 object.
        /// </summary>
        public NewPublisherEntities2(EntityConnection connection) : base(connection, "NewPublisherEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Author> Authors
        {
            get
            {
                if ((_Authors == null))
                {
                    _Authors = base.CreateObjectSet<Author>("Authors");
                }
                return _Authors;
            }
        }
        private ObjectSet<Author> _Authors;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Authors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAuthors(Author author)
        {
            base.AddObject("Authors", author);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NewPublisherModel", Name="Author")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Author : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Author object.
        /// </summary>
        /// <param name="authorID">Initial value of the AuthorID property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        public static Author CreateAuthor(global::System.Int32 authorID, global::System.String lastName, global::System.String firstName)
        {
            Author author = new Author();
            author.AuthorID = authorID;
            author.LastName = lastName;
            author.FirstName = firstName;
            return author;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AuthorID
        {
            get
            {
                return _AuthorID;
            }
            set
            {
                if (_AuthorID != value)
                {
                    OnAuthorIDChanging(value);
                    ReportPropertyChanging("AuthorID");
                    _AuthorID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AuthorID");
                    OnAuthorIDChanged();
                }
            }
        }
        private global::System.Int32 _AuthorID;
        partial void OnAuthorIDChanging(global::System.Int32 value);
        partial void OnAuthorIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> OnPanelDate
        {
            get
            {
                return _OnPanelDate;
            }
            set
            {
                OnOnPanelDateChanging(value);
                ReportPropertyChanging("OnPanelDate");
                _OnPanelDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OnPanelDate");
                OnOnPanelDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _OnPanelDate;
        partial void OnOnPanelDateChanging(Nullable<global::System.DateTime> value);
        partial void OnOnPanelDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewPublisherModel", "FK_Author_Book", "Book")]
        public EntityCollection<Book> Books
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Book>("NewPublisherModel.FK_Author_Book", "Book");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Book>("NewPublisherModel.FK_Author_Book", "Book", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NewPublisherModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="bookISBN">Initial value of the BookISBN property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="pages">Initial value of the Pages property.</param>
        /// <param name="publishing_Date">Initial value of the Publishing_Date property.</param>
        /// <param name="authorID">Initial value of the AuthorID property.</param>
        public static Book CreateBook(global::System.String bookISBN, global::System.String title, global::System.Int32 pages, global::System.DateTime publishing_Date, global::System.Int32 authorID)
        {
            Book book = new Book();
            book.BookISBN = bookISBN;
            book.Title = title;
            book.Pages = pages;
            book.Publishing_Date = publishing_Date;
            book.AuthorID = authorID;
            return book;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookISBN
        {
            get
            {
                return _BookISBN;
            }
            set
            {
                if (_BookISBN != value)
                {
                    OnBookISBNChanging(value);
                    ReportPropertyChanging("BookISBN");
                    _BookISBN = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("BookISBN");
                    OnBookISBNChanged();
                }
            }
        }
        private global::System.String _BookISBN;
        partial void OnBookISBNChanging(global::System.String value);
        partial void OnBookISBNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Pages
        {
            get
            {
                return _Pages;
            }
            set
            {
                OnPagesChanging(value);
                ReportPropertyChanging("Pages");
                _Pages = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Pages");
                OnPagesChanged();
            }
        }
        private global::System.Int32 _Pages;
        partial void OnPagesChanging(global::System.Int32 value);
        partial void OnPagesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Publishing_Date
        {
            get
            {
                return _Publishing_Date;
            }
            set
            {
                OnPublishing_DateChanging(value);
                ReportPropertyChanging("Publishing_Date");
                _Publishing_Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Publishing_Date");
                OnPublishing_DateChanged();
            }
        }
        private global::System.DateTime _Publishing_Date;
        partial void OnPublishing_DateChanging(global::System.DateTime value);
        partial void OnPublishing_DateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AuthorID
        {
            get
            {
                return _AuthorID;
            }
            set
            {
                OnAuthorIDChanging(value);
                ReportPropertyChanging("AuthorID");
                _AuthorID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AuthorID");
                OnAuthorIDChanged();
            }
        }
        private global::System.Int32 _AuthorID;
        partial void OnAuthorIDChanging(global::System.Int32 value);
        partial void OnAuthorIDChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewPublisherModel", "FK_Author_Book", "Author")]
        public Author Author
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Author>("NewPublisherModel.FK_Author_Book", "Author").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Author>("NewPublisherModel.FK_Author_Book", "Author").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Author> AuthorReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Author>("NewPublisherModel.FK_Author_Book", "Author");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Author>("NewPublisherModel.FK_Author_Book", "Author", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
