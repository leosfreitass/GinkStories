FROM node:lts-alpine

WORKDIR /app

COPY package*.json .

RUN npm ci

COPY . .

COPY entrypoint.sh /docker-entrypoint/entrypoint.sh
RUN chmod +x /docker-entrypoint/entrypoint.sh

EXPOSE 4200

ENTRYPOINT [ "/docker-entrypoint/entrypoint.sh" ]


