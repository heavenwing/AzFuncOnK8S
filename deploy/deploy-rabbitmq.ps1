helm repo add bitnami https://charts.bitnami.com/bitnami
helm install rabbitmq --set rabbitmq.password=PASSWORD,service.type=LoadBalancer bitnami/rabbitmq