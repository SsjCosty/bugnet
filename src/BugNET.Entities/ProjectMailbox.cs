using System;

namespace BugNET.Entities
{
	/// <summary>
	/// Summary description for ProjectMailbox.
	/// </summary>
	public class ProjectMailbox
	{
		#region Private Variables
		private string _mailbox;
		private int _projectId;
		private Guid _assignToId;
		private int _issueTypeId;
		private string _AssignToDisplayName;
		private string _IssueTypeName;
		private int _Id;
        private string _AssignToUserName;
		#endregion

		#region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ProjectMailbox"/> class.
        /// </summary>
        /// <param name="mailbox">The mailbox.</param>
        /// <param name="projectId">The project id.</param>
        /// <param name="assignToName">Name of the assign to.</param>
        /// <param name="assignToId">The assign to id.</param>
        /// <param name="issueTypeId">The issue type id.</param>
		public ProjectMailbox(string mailbox, int projectId, string assignToUserName,Guid assignToId,string assignToDisplayName, int issueTypeId)
		{
			_mailbox = mailbox;
			_projectId = projectId;
			_assignToId = assignToId;
            _AssignToUserName = assignToUserName;
            _AssignToDisplayName = assignToDisplayName;
			_issueTypeId = issueTypeId;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ProjectMailbox"/> class.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="mailbox">The mailbox.</param>
        /// <param name="projectId">The project id.</param>
        /// <param name="assignToId">The assign to id.</param>
        /// <param name="issueTypeId">The issue type id.</param>
        /// <param name="assignToName">Name of the assign to.</param>
        /// <param name="issueTypeName">Name of the issue type.</param>
		public ProjectMailbox(int id,string mailbox, int projectId,Guid assignToId, int issueTypeId, string assignToUserName,string assignToDisplayName, string issueTypeName)
		{
			_Id = id;
			_mailbox = mailbox;
			_projectId = projectId;
			_assignToId = assignToId;
			_issueTypeId = issueTypeId;
            _AssignToUserName = assignToUserName;
            _AssignToDisplayName = assignToDisplayName;
			_IssueTypeName = issueTypeName;
		}
		#endregion

		#region Properties
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>The id.</value>
		public int Id
		{
			get{return _Id;}
            set { _Id = value; }
		}
        /// <summary>
        /// Gets the mailbox.
        /// </summary>
        /// <value>The mailbox.</value>
		public string Mailbox
		{
			get{return _mailbox;}
            set { _mailbox = value; }
		}
        /// <summary>
        /// Gets the project id.
        /// </summary>
        /// <value>The project id.</value>
		public int ProjectId
		{
			get{return _projectId;}
		}
        /// <summary>
        /// Gets the assign to ID.
        /// </summary>
        /// <value>The assign to ID.</value>
		public Guid AssignToId
		{
			get{return _assignToId;}
           
		}
        /// <summary>
        /// Gets the issue type id.
        /// </summary>
        /// <value>The issue type id.</value>
		public int IssueTypeId
		{
			get{return _issueTypeId;}
            set { _issueTypeId = value; }
		}
        /// <summary>
        /// Gets the name of the assign to.
        /// </summary>
        /// <value>The name of the assign to.</value>
		public string AssignToDisplayName
		{
			get{return _AssignToDisplayName;}
		}

        /// <summary>
        /// Gets the assign to UserName.
        /// </summary>
        /// <value>The assign to UserName.</value>
        public string AssignToUserName
        {
            get { return _AssignToUserName; }
            set { _AssignToUserName = value; }
        }

        /// <summary>
        /// Gets the name of the issue type.
        /// </summary>
        /// <value>The name of the issue type.</value>
		public string IssueTypeName
		{
			get{return _IssueTypeName;}
		}
		#endregion



	}
}
