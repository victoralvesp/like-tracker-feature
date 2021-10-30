# LikeTrackingSystem - ASP.NET Core 5.0 Server

A like tracking system for Article likes.

## Description

Tracks likes for articles defined using a UUID for unique identification.
The backend system is composed of three parts: a `API` gateway, a `Tracker` service for which users liked articles and a `Counter` service to track the number of likes for each article.

The archictecure can be seen through the diagrams: [Get likes](docs/architecture/diagrams/out/__WorkspaceFolder__/docs/architecture/src/article-loading-system/articleloading.svg) and [New like](docs/architecture/diagrams/out/__WorkspaceFolder__/docs/architecture/src/like-tracking-component/messagebus.svg) both created using the diagrams found in [Architecture](docs/architecture/).


## Architecture summary

The components of the system are all defined using a simple microservice architecture.

- To ensure CQRS each component is defined has its own database.
- The components communicate with each other using a message broker.
- Likes are tracked using a simple NoSQL database.
- Like counts are tracked using a distributed cache and a simple NoSQL database to avoid duplicate event counting.

This system ensures scalability, through the use of microservices and async communication (via message brokers).

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## TODO

Because of time restraints, the project is not fully production ready. The following features are missing:
- [ ] Article Like tracking persistence
- [ ] Count tracking persistence
- [ ] Events counted persistence
- [ ] Remove like for user
- [ ] Message broker integration (using Message board interface)
- [ ] `Like` frontend component (possibly a simple button with a label for counts)