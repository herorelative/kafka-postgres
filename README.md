# kafka

### Zookeeper (zookeeper service)

Purpose: Kafka relies on Zookeeper for managing and coordinating brokers in a Kafka cluster.
Role in the setup:

- Keeps track of Kafka brokers (who is active/inactive).
- Manages leader election for Kafka partitions.
- Stores metadata (such as topics, partitions, etc.).

### Kafka (kafka service)

Purpose: Kafka is a distributed event streaming platform used for high-throughput messaging.
Role in the setup:

- Allows applications to publish and subscribe to messages (topics).
- Provides high availability and fault tolerance.
- Stores and processes real-time data streams.

### Run Dev Continer to be Ready

```sh
docker-compose up -d
```

### To check all container staus of Dev Env

```sh
docker ps
```

### Run this applications:

```sh
dotnet run
```

### 🔄 Restart Everything

After making any changes in docker-compose.yml, restart your setup:

```sh
docker-compose down -v
docker-compose up -d
```
