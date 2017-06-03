using System;

namespace S22.Imap {
	/// <summary>
	/// Provides data for IMAP idle notification events.
	/// </summary>
	public class IdleMessageEventArgs : EventArgs {
		/// <summary>
		/// Initializes a new instance of the IdleMessageEventArgs class and sets the
		/// MessageCount attribute to the value of the <paramref name="messageCount"/>
		/// parameter.
		/// </summary>
		/// <param name="messageCount">The number of messages in the selected mailbox.</param>
		/// <param name="messageUid"> The unique identifier (UID) of the newest message in the
		/// mailbox.</param>
		/// <param name="client">The instance of the ImapClient class that raised the event.</param>
		internal IdleMessageEventArgs(uint messageCount, uint messageUid,
			ImapClient client) {
			this.MessageCount = messageCount;
			this.MessageUid = messageUid;
			this.Client = client;
		}

		/// <summary>
		/// The total number of messages in the selected mailbox.
		/// </summary>
		public uint MessageCount {
			get;
			private set;
		}

		/// <summary>
		/// The unique identifier (UID) of the newest message in the mailbox. 
		/// </summary>
		/// <remarks>The UID can be passed to the GetMessage method in order to retrieve the mail
		/// message from the server.</remarks>
		public uint MessageUid {
			get;
			private set;
		}

		/// <summary>
		/// The instance of the ImapClient class that raised the event.
		/// </summary>
		public ImapClient Client {
			get;
			private set;
		}
	}
}
