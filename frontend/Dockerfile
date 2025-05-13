FROM node:alpine
WORKDIR /app/frontend

ENV PATH /app/frontend/node_modules/.bin:$PATH

COPY package.json /app/frontend/package.json
RUN npm install
RUN npm install -g @angular/cli@latest

COPY . /app/frontend

CMD ["ng", "serve", "--host", "0.0.0.0"]


