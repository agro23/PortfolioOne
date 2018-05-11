using System;
using System.Collections.Generic;

namespace Portfolio.Models
{
    public class StarredProject
    {
        public string name { get; set; }
        public string html_url { get; set; }

        // LIKE TO HAVE THESE BUT THEY'LL HAVE TO BE PARSED SEPARATELY
        public List<string> Stargazers { get; set; } // "stargazers_url": "https://api.github.com/repos/agro23/xrystal/stargazers",

    }
}
/*

{
            "id": 128805517,
            "name": "xrystal",
            "full_name": "agro23/xrystal",
            "owner": {
                "login": "agro23",
                "id": 15318517,
                "avatar_url": "https://avatars2.githubusercontent.com/u/15318517?v=4",
                "gravatar_id": "",
                "url": "https://api.github.com/users/agro23",
                "html_url": "https://github.com/agro23",
                "followers_url": "https://api.github.com/users/agro23/followers",
                "following_url": "https://api.github.com/users/agro23/following{/other_user}",
                "gists_url": "https://api.github.com/users/agro23/gists{/gist_id}",
                "starred_url": "https://api.github.com/users/agro23/starred{/owner}{/repo}",
                "subscriptions_url": "https://api.github.com/users/agro23/subscriptions",
                "organizations_url": "https://api.github.com/users/agro23/orgs",
                "repos_url": "https://api.github.com/users/agro23/repos",
                "events_url": "https://api.github.com/users/agro23/events{/privacy}",
                "received_events_url": "https://api.github.com/users/agro23/received_events",
                "type": "User",
                "site_admin": false
            },
            "private": false,
            "html_url": "https://github.com/agro23/xrystal",
            "description": "Epicodus Week 5 Angular project",
            "fork": false,
            "url": "https://api.github.com/repos/agro23/xrystal",
            "forks_url": "https://api.github.com/repos/agro23/xrystal/forks",
            "keys_url": "https://api.github.com/repos/agro23/xrystal/keys{/key_id}",
            "collaborators_url": "https://api.github.com/repos/agro23/xrystal/collaborators{/collaborator}",
            "teams_url": "https://api.github.com/repos/agro23/xrystal/teams",
            "hooks_url": "https://api.github.com/repos/agro23/xrystal/hooks",
            "issue_events_url": "https://api.github.com/repos/agro23/xrystal/issues/events{/number}",
            "events_url": "https://api.github.com/repos/agro23/xrystal/events",
            "assignees_url": "https://api.github.com/repos/agro23/xrystal/assignees{/user}",
            "branches_url": "https://api.github.com/repos/agro23/xrystal/branches{/branch}",
            "tags_url": "https://api.github.com/repos/agro23/xrystal/tags",
            "blobs_url": "https://api.github.com/repos/agro23/xrystal/git/blobs{/sha}",
            "git_tags_url": "https://api.github.com/repos/agro23/xrystal/git/tags{/sha}",
            "git_refs_url": "https://api.github.com/repos/agro23/xrystal/git/refs{/sha}",
            "trees_url": "https://api.github.com/repos/agro23/xrystal/git/trees{/sha}",
            "statuses_url": "https://api.github.com/repos/agro23/xrystal/statuses/{sha}",
            "languages_url": "https://api.github.com/repos/agro23/xrystal/languages",
            "stargazers_url": "https://api.github.com/repos/agro23/xrystal/stargazers",
            "contributors_url": "https://api.github.com/repos/agro23/xrystal/contributors",
            "subscribers_url": "https://api.github.com/repos/agro23/xrystal/subscribers",
            "subscription_url": "https://api.github.com/repos/agro23/xrystal/subscription",
            "commits_url": "https://api.github.com/repos/agro23/xrystal/commits{/sha}",
            "git_commits_url": "https://api.github.com/repos/agro23/xrystal/git/commits{/sha}",
            "comments_url": "https://api.github.com/repos/agro23/xrystal/comments{/number}",
            "issue_comment_url": "https://api.github.com/repos/agro23/xrystal/issues/comments{/number}",
            "contents_url": "https://api.github.com/repos/agro23/xrystal/contents/{+path}",
            "compare_url": "https://api.github.com/repos/agro23/xrystal/compare/{base}...{head}",
            "merges_url": "https://api.github.com/repos/agro23/xrystal/merges",
            "archive_url": "https://api.github.com/repos/agro23/xrystal/{archive_format}{/ref}",
            "downloads_url": "https://api.github.com/repos/agro23/xrystal/downloads",
            "issues_url": "https://api.github.com/repos/agro23/xrystal/issues{/number}",
            "pulls_url": "https://api.github.com/repos/agro23/xrystal/pulls{/number}",
            "milestones_url": "https://api.github.com/repos/agro23/xrystal/milestones{/number}",
            "notifications_url": "https://api.github.com/repos/agro23/xrystal/notifications{?since,all,participating}",
            "labels_url": "https://api.github.com/repos/agro23/xrystal/labels{/name}",
            "releases_url": "https://api.github.com/repos/agro23/xrystal/releases{/id}",
            "deployments_url": "https://api.github.com/repos/agro23/xrystal/deployments",
            "created_at": "2018-04-09T16:55:50Z",
            "updated_at": "2018-05-11T15:27:20Z",
            "pushed_at": "2018-04-24T00:07:44Z",
            "git_url": "git://github.com/agro23/xrystal.git",
            "ssh_url": "git@github.com:agro23/xrystal.git",
            "clone_url": "https://github.com/agro23/xrystal.git",
            "svn_url": "https://github.com/agro23/xrystal",
            "homepage": null,
            "size": 116789,
            "stargazers_count": 2,
            "watchers_count": 2,
            "language": "TypeScript",
            "has_issues": true,
            "has_projects": true,
            "has_downloads": true,
            "has_wiki": true,
            "has_pages": false,
            "forks_count": 1,
            "mirror_url": null,
            "archived": false,
            "open_issues_count": 0,
            "license": null,
            "forks": 1,
            "open_issues": 0,
            "watchers": 2,
            "default_branch": "master",
            "score": 1
        }

 */