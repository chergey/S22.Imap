using System;

namespace S22.Imap.Enums {
	/// <summary>
	/// Represents the status information of a mailbox which can be constructed from the server
	/// response to a STATUS command.
	/// </summary>
	[Serializable]
	internal class MailboxStatus {
		/// <summary>
		/// Initializes a new MailboxStatus instance with the specified number of total and unread
		/// messages.
		/// </summary>
		/// <param name="messages">The total number of messages in the mailbox.</param>
		/// <param name="unread">The number of unread (unseen) messages in the mailbox.</param>
		/// <param name="nextUid">The next unique identifier value of the mailbox</param>
		internal MailboxStatus(int messages, int unread, uint nextUid) {
			this.Messages = messages;
			this.Unread = unread;
			this.NextUid = nextUid;
		}

		/// <summary>
		/// The next unique identifier value of the mailbox.
		/// </summary>
		internal uint NextUid {
			get;
			private set;
		}

		/// <summary>
		/// The total number of messages in the mailbox.
		/// </summary>
		internal int Messages {
			get;
			private set;
		}

		/// <summary>
		/// The number of unread (unseen) messages in the mailbox.
		/// </summary>
		internal int Unread {
			get;
			private set;
		}
	}
}
