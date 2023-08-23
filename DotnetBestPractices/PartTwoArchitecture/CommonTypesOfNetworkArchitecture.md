Several common forms of network architecture are used today to support various types of applications and connectivity requirements. Here are some of the most prevalent ones:

1. **Client-Server Architecture:** This is one of the most common network architectures. In a client-server setup, clients (user devices or software) request services or resources from centralized servers. Servers handle requests and provide resources (data, files, applications, etc.). This architecture is often used in web applications, email systems, and database systems.
```text
   +---------+          +---------+
   |  Client | <----->  |  Server |
   +---------+          +---------+
 ```
2. **Peer-to-Peer (P2P) Architecture:** In a P2P network, devices (peers) directly communicate with each other, sharing resources and responsibilities without relying on a central server. This architecture is often used in file sharing applications, voice/video conferencing, and some blockchain systems.
```text
     +---------+       +---------+
     |   Peer  | <-->  |   Peer  |
     +---------+       +---------+
```
3. **Three-Tier Architecture:** This architecture divides an application into three layers: presentation, logic, and data. The presentation layer handles user interface interactions, the logic layer (also called the application or business logic layer) manages application functionality, and the data layer manages data storage and retrieval. This separation of concerns allows for easier maintenance and scalability.
```text
     +----------------+      +----------------+      +----------------+
     |  Presentation  | <--> |   Application  | <--> |      Data      |
     |    Layer       |      |     Layer      |      |     Layer      |
     +----------------+      +----------------+      +----------------+
```
4. **Microservices Architecture:** In this architecture, applications are broken down into smaller, independently deployable services that communicate over a network. Each service focuses on a specific functionality and can be developed, deployed, and scaled independently. This is often used in modern web applications to achieve agility and scalability.
```text
     +------------+      +------------+      +------------+
     |  Micro     | <--> |  Micro     | <--> |  Micro     |
     |  Service   |      |  Service   |      |  Service   |
     +------------+      +------------+      +------------+
```
5. **Service-Oriented Architecture (SOA):** SOA is an approach where software components, called services, provide well-defined interfaces for other components to use. Services are loosely coupled and can be located on different servers. This architecture promotes reusability and interoperability of components.
```text
     +------------+      +------------+      +------------+
     |  Micro     | <--> |  Micro     | <--> |  Micro     |
     |  Service   |      |  Service   |      |  Service   |
     +------------+      +------------+      +------------+
```
6. **Serverless Architecture:** In serverless computing, developers write functions that run in response to events. The cloud provider manages the underlying infrastructure, automatically scaling and allocating resources as needed. This allows developers to focus on writing code without worrying about server management.
```text
               +-------------------+
 Event ------> |   Serverless      |
 Trigger       |    Platform       |
               +-------------------+
```
7. **Containerization Architecture:** Containers encapsulate applications and their dependencies, allowing them to run consistently across different environments. This architecture, often associated with technologies like Docker and Kubernetes, is used to build, deploy, and manage applications at scale.
```text
+------------------------------------+
|           Docker Engine             |
|                                    |
|  +-----------+    +-----------+    |
|  | Container |    | Container |    |
|  +-----------+    +-----------+    |
+------------------------------------+
```
8. **Edge Computing Architecture:** Edge computing brings computation and data storage closer to the location where it is needed, reducing latency and bandwidth usage. It's particularly useful for applications that require real-time processing, like IoT (Internet of Things) devices and autonomous vehicles.
```text
                 +-------+
 Devices <---->  |  Edge |
                 |Device |
                 +-------+
```
9. **Hybrid Cloud Architecture:** Hybrid cloud combines public and private cloud infrastructure, allowing organizations to take advantage of both. Critical or sensitive workloads can run on a private cloud, while less sensitive workloads can be hosted on a public cloud, providing flexibility and cost optimization.
```text
     +-------------------+
     |    Public Cloud   |
     |                   |
     +-------------------+
             ^
             |
     +-------------------+
     |    Private Cloud  |
     |                   |
     +-------------------+
```
10. **Virtual Private Network (VPN) Architecture:** VPNs allow secure communication over public networks by creating a private network connection through encryption. This architecture is commonly used to enable remote access to corporate networks or to establish secure connections between geographically distributed sites.
```text
     +---------+    encrypted      +---------+
     |   User  | <---------------> |   VPN   |
     |  Device |      channel      | Gateway |
     +---------+                   +---------+
```
These are just a few examples of network architectures used today. The choice of architecture depends on factors such as the nature of the application, scalability requirements, security considerations, and the specific needs of the organization.