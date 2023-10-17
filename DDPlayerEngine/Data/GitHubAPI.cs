using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PlayerEngine.Data.APIs {

    [Serializable]
    public class GitFile {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Sha { get; set; }
        public int Size { get; set; }
        public string Url { get; set; }
        public string Html_url { get; set; }
        public string Git_url { get; set; }
        public string Download_url { get; set; }
        public string Type { get; set; }
        [JsonPropertyName("_links")]
        public Dictionary<string, string> Links { get; set; }
    }
    [Serializable]
    public class GitIssue {
        public string Url { get; set; }
        public string Repository_url { get; set; }
        public string Labels_url { get; set; }
        public string Comments_url { get; set; }
        public string Events_url { get; set; }
        public string Html_url { get; set; }
        public long Id { get; set; }
        public string Node_id { get; set; }
        public long Number { get; set; }
        public string Title { get; set; }
        public GitUser User { get; set; }
        public GitLabel[] Labels { get; set; }
        public string State { get; set; }
        public bool Locked { get; set; }
        public GitUser Assignee { get; set; }
        public GitUser[] Assignees { get; set; }
        public int Comments { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
        public string Closed_at { get; set; }
        public string Author_association { get; set; }
        public string Active_lock_reason { get; set; }
        public string Body { get; set; }
        public GitReaction Reactions { get; set; }
        public string Timeline_url { get; set; }
        public string Performed_via_github_app { get; set; }
        public string State_reason { get; set; }
    }
    [Serializable]
    public class GitCommit {
        public string Sha { get; set; }

        [JsonPropertyName("commit")]
        public GitCommitDetails Details { get; set; }

        public string Html_Url { get; set; }
    }
    [Serializable]
    public class GitCommitDetails {
        public GitCommitAuthor Author { get; set; }
        public GitCommitAuthor Committer { get; set; }
        public string Message { get; set; }
    }
    [Serializable]
    public class GitCommitAuthor {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
    [Serializable]
    public class GitLabel {
        public long Id { get; set; }
        public string Node_id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        [JsonPropertyName("_default")]
        public bool Default { get; set; }
        public string Description { get; set; }
    }
    [Serializable]
    public class GitUser {
        public string Login { get; set; }
        public long Id { get; set; }
        public string Node_id { get; set; }
        public string Avatar_id { get; set; }
        public string Gravatar_id { get; set; }
        public string Url { get; set; }
        public string Html_url { get; set; }
        public string Followers_url { get; set; }
        public string Following_url { get; set; }
        public string Gists_url { get; set; }
        public string Starred_url { get; set; }
        public string Subscriptions_url { get; set; }
        public string Organizations_url { get; set; }
        public string Repos_url { get; set; }
        public string Events_url { get; set; }
        public string Received_events_url { get; set; }
        public string Type { get; set; }
        public bool Site_admin { get; set; }
    }
    [Serializable]
    public class GitReaction {
        public string Url { get; set; }
        public int Total_count { get; set; }
        [JsonPropertyName("+1")]
        public int UpVote { get; set; }
        [JsonPropertyName("-1")]
        public int DownVote { get; set; }
        public int Laugh { get; set; }
        public int Hooray { get; set; }
        public int Confused { get; set; }
        public int Heart { get; set; }
        public int Rocket { get; set; }
        public int Eyes { get; set; }
    }
}
