# Use a imagem oficial do Jenkins com suporte ao Docker
FROM jenkins/jenkins:lts-jdk11

# Mude para o usuário root para instalar dependências
USER root

# Instale o .NET SDK
RUN apt-get update \
    && apt-get install -y wget \
    && wget https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && apt-get update \
    && apt-get install -y apt-transport-https \
    && apt-get update \
    && apt-get install -y dotnet-sdk-7.0

RUN apt-get install -y mailutils
RUN dotnet tool install --global dotnet-reportgenerator-globaltool

ENV PATH="${PATH}:/var/jenkins_home/.dotnet/tools"

RUN chmod -R 777 /bin/dotnet
# Volte para o usuário Jenkins
USER jenkins

