# Kubernetes testing with ASP.NET 5

A testing repository to adventure on Kubernetes land using ASP.NET 5 and docker. I have included below the steps to deploy in a Kubernetes cluster in Digitalocean or locally.

## Requirements

- [Docker desktop](https://www.docker.com/products/docker-desktop) with kubernetes enabled
- [Minikube](https://minikube.sigs.k8s.io/docs/start/)

## Setup for localhost

Start minikube server in your terminal (Needs Administrator permission)
```
minikube start
```

In a new terminal open a new session and run the following command
```
minikube tunnel
```

## Build

To get started navigate to K8STest folder

```
cd K8STest
```

Build the docker image ( In case you are in localhost remember to remove `imagePullPolicy: Never` from the deployment.yml file

```
docker build -f Dockerfile -t waterball/k8stest:latest ..
```

If instead want to deploy to a Kubernetes cluster login in to your docker hub account or other provider
```
docker login
```

Again if you want to deploy to a kubernetes cluster also run

```
docker push {USERNAME}/k8stest:latest
```

## Deploy

Create the deployment 

```
kubectl create -f .\deployment.yml
```

To check if the deployment has been successful check

```
kubectl get development

kubectl get pods
```

Navigate to the web api by getting the IP where the cluster service is running

```
kubectl get service
```

Copy and paste the External IP and navigate to it
```
http://{External_IP}:80/test
```







