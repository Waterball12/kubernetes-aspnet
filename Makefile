


ENV=staging


build-image:
	docker build -f Dockerfile -t waterball/webapi:latest .