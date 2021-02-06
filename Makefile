


ENV=staging


build-image:
	docker build -f Dockerfile -t waterball/k8stest:latest .
